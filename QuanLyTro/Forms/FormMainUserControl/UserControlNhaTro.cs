using QuanLyTro.Forms.Dialog;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Data.SQLite;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyTro.Forms.FormMainUserControl
{
    public partial class UserControlNhaTro : UserControl
    {
        //Dùng để lấy mã khoá gán cho Nhà Trọ
        //Khi truy vấn layMaKhoaNhaTro sẽ trã về giá trị khoá cũ+1 chỉ
        //cần thêm vào "TRO-"+layMaKhoaNhaTro sẽ có mã khoá nhà trọ
        private int _layMaKhoaNhaTro;
        private int layMaKhoaNhaTro
        {
            get
            {
                _layMaKhoaNhaTro++;
                return _layMaKhoaNhaTro;
            }
            set
            {
                _layMaKhoaNhaTro = value;
            }
        }

        public UserControlNhaTro()
        {
            InitializeComponent();
        }
        private void UserControlNhaTro_Load(object sender, EventArgs e)
        {
            //Kiểm tra xem Form có đang trong chế độ thiết kế không nếu có thì không load tránh lỗi
            if (this.DesignMode)
            {
                return;
            }

            //Truy vấn mã lớn nhất trong bản để tạo mã khoá cho các dữ liệu sau này
            using (SQLiteCommand truyVan = new SQLiteCommand("SELECT MAX(CAST(SUBSTR(Ma, 5) AS INTEGER)) FROM NhaTro;", CauHinh.CSDL))
            {
                object result = truyVan.ExecuteScalar();
                layMaKhoaNhaTro = result != DBNull.Value ? Convert.ToInt32(result) : 0;
            }

            //Tải danh sách nhà trọ từ cơ sở dữ liệu
            using (SQLiteCommand truyVan = new SQLiteCommand("SELECT Ma, Ten, SoLuongPhong, DiaChi, GhiChu FROM NhaTro WHERE Xoa==0", CauHinh.CSDL))
            using (SQLiteDataReader doc = truyVan.ExecuteReader())
            {
                while (doc.Read())
                {
                    //Thêm dữ liệu vào lvNhaTro
                    ListViewItem item = new ListViewItem((string)doc["Ma"]);
                    item.SubItems.Add((string)doc["Ten"]);
                    item.SubItems.Add(((Int64)doc["SoLuongPhong"]).ToString());
                    item.SubItems.Add((string)doc["DiaChi"]);
                    item.SubItems.Add((string)doc["GhiChu"]);
                    this.lvNhaTro.Items.Add(item);
                }
            }
        }
        private void them_Click(object sender, EventArgs e)
        {
            try
            {
                //Tạo luồng mới để tránh form chính bị đơ khi thực hiện tác vụ
                Task.Run(() =>
                {
                    //Tạo diaglog bằng form ThemNhaTro
                    ThemNhaTro themNhaTro = new ThemNhaTro();
                    //Nếu trả về OK thì bắt đầu thêm dữ liệu vào database
                    if (themNhaTro.ShowDialog() == DialogResult.OK)
                    {
                        //Tạo mã khoá nhà trọ
                        string maNhaTro = string.Format("TRO-{0}", layMaKhoaNhaTro);

                        //Thêm dữ liệu vào lvNhaTro
                        //Phải sử dụng Invoke vì đang ở luồng khác
                        Invoke((MethodInvoker)(() =>
                        {
                            ListViewItem item = new ListViewItem(maNhaTro);
                            item.SubItems.Add(themNhaTro.TenNhaTro);
                            item.SubItems.Add(themNhaTro.SoLuongPhong.ToString());
                            item.SubItems.Add(themNhaTro.DiaChi);
                            item.SubItems.Add(themNhaTro.GhiChu);
                            this.lvNhaTro.Items.Add(item);
                        }));

                        //Thêm dữ liệu vào cơ sở dữ liệu
                        using (SQLiteCommand truyVan = new SQLiteCommand("INSERT INTO NhaTro (Ma, Ten, SoLuongPhong, DiaChi, GhiChu, Xoa) VALUES (@ma, @ten, @soLuongPhong, @diaChi, @ghiChu, 0);", CauHinh.CSDL))
                        {
                            truyVan.Parameters.AddWithValue("@ma", maNhaTro);
                            truyVan.Parameters.AddWithValue("@ten", themNhaTro.TenNhaTro);
                            truyVan.Parameters.AddWithValue("@soLuongPhong", themNhaTro.SoLuongPhong);
                            truyVan.Parameters.AddWithValue("@diaChi", themNhaTro.DiaChi);
                            truyVan.Parameters.AddWithValue("@ghiChu", themNhaTro.GhiChu);

                            truyVan.ExecuteNonQuery();
                        }
                    }
                });
            }
            catch (Exception err)
            {
                MaterialMessageBox.Show(err.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            ListViewItem[] danhSachNhaTro = layDanhSachChonNhaTro();

            if (danhSachNhaTro.Length < 1)
            {
                return;
            }

            foreach (ListViewItem nhaTro in danhSachNhaTro)
            {
                Task.Run(() =>
                {
                    //Tạo dialog sửa nhà trọ
                    SuaNhaTro suaNhaTro = new SuaNhaTro();

                    //Gán giá trị của nhà trọ cần sửa cho textbox trong dialog
                    suaNhaTro.txTenNhaTro.Text = nhaTro.SubItems[1].Text;
                    suaNhaTro.txDiaChi.Text = nhaTro.SubItems[3].Text;
                    suaNhaTro.txGhiChu.Text = nhaTro.SubItems[4].Text;

                    //Nếu trả về OK thì bắt đầu thêm dữ liệu vào database
                    if (suaNhaTro.ShowDialog() == DialogResult.OK)
                    {
                        //Kiểm tra nếu các giá trị không thay đổi thì không cần thay đổi mà trực tiếp thoát
                        if(suaNhaTro.TenNhaTro == nhaTro.SubItems[1].Text && suaNhaTro.DiaChi == nhaTro.SubItems[3].Text && suaNhaTro.txGhiChu.Text == nhaTro.SubItems[4].Text)
                        {
                            return;
                        }

                        //Tìm listviewitem và chỉnh sửa cho đúng giá trị mới chỉnh sửa, không dùng foreach vì không trỏ tới đúng item đó 
                        Invoke((MethodInvoker)(() =>
                        {
                            for (int i = 0; i < lvNhaTro.Items.Count; i++)
                            {
                                if (lvNhaTro.Items[i].Text == nhaTro.Text)
                                {
                                    lvNhaTro.Items[i].SubItems[1].Text = suaNhaTro.TenNhaTro;
                                    lvNhaTro.Items[i].SubItems[3].Text = suaNhaTro.DiaChi;
                                    lvNhaTro.Items[i].SubItems[4].Text = suaNhaTro.GhiChu;
                                    break;
                                }
                            }
                        }));

                        //Cập nhật giá trị trong database
                        using (SQLiteCommand truyVan = new SQLiteCommand("UPDATE NhaTro SET Ten = @ten, DiaChi = @diaChi, GhiChu = @ghiChu WHERE Ma = @ma", CauHinh.CSDL))
                        {
                            truyVan.Parameters.AddWithValue("@ma", nhaTro.Text);
                            truyVan.Parameters.AddWithValue("@ten", suaNhaTro.TenNhaTro);
                            truyVan.Parameters.AddWithValue("@diaChi", suaNhaTro.DiaChi);
                            truyVan.Parameters.AddWithValue("@ghiChu", suaNhaTro.GhiChu);
                            truyVan.ExecuteNonQuery();
                        }
                    }
                });

            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            //Lấy danh sách nhà trọ cần xoá mà người dùng đang chọn
            ListViewItem[] danhSachNhaTro = layDanhSachChonNhaTro();

            //Nếu người dùng đang không chọn nhà trọ nào thì return
            if (danhSachNhaTro.Length < 1)
            {
                return;
            }

            //Tạo luồng mới để tránh form chính bị đơ khi thực hiện tác vụ
            Task.Run(() =>
            {
                foreach (ListViewItem nhaTro in danhSachNhaTro)
                {
                    //Xoá dữ liệu khỏi listview nhà trọ
                    //Phải sử dụng Invoke vì đang ở luồng khác
                    Invoke((MethodInvoker)(() =>
                    {
                        lvNhaTro.Items.Remove(nhaTro);
                    }));
                }
                foreach (ListViewItem nhaTro in danhSachNhaTro)
                {
                    //Xoá nhà trọ khỏi cơ sở dữ liệu bằng cách chuyển cột Xoa sang 1
                    using (SQLiteCommand truyVan = new SQLiteCommand("UPDATE NhaTro SET Xoa = 1 WHERE Ma = @ma", CauHinh.CSDL))
                    {
                        truyVan.Parameters.AddWithValue("@ma", nhaTro.Text);
                        truyVan.ExecuteNonQuery();
                    }
                }
            });
        }

        //Lấy danh sách nhà trọ đang chọn
        private ListViewItem[] layDanhSachChonNhaTro()
        {
            List<ListViewItem> danhSachNhaTro = new List<ListViewItem>();
            foreach (ListViewItem nhaTro in lvNhaTro.SelectedItems)
            {
                danhSachNhaTro.Add(nhaTro);
            }
            return danhSachNhaTro.ToArray();
        }
    }
}
