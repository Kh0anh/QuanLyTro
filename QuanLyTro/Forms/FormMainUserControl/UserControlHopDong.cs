using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTro.Forms.Dialog;
using ReaLTaiizor.Controls;

namespace QuanLyTro.Forms.FormMainUserControl
{
    public partial class UserControlHopDong : UserControl
    {
        public UserControlHopDong()
        {
            InitializeComponent();
        }

        private void UserControlHopDong_Load(object sender, EventArgs e)
        {
            //Kiểm tra Form có đang trong chế độ thiết kế hay không, nếu có thì không Load để tránh lỗi
            if (this.DesignMode)
            {
                return;
            }

            //Load danh sách hợp đồng từ csdl
            using (SQLiteCommand query = new SQLiteCommand("SELECT Ma, NgayBatDau, NgayKetThuc, GiaThue, TienCoc, SoNguoiO, MaKhachHang FROM HopDong WHERE Xoa == 0", CauHinh.CSDL))
            using (SQLiteDataReader doc = query.ExecuteReader())
            {
                while (doc.Read())
                {
                    //Thêm dữ liệu vào mlvHopDong
                    ListViewItem item = new ListViewItem((string)doc["Ma"]);
                    item.SubItems.Add((string)doc["MaKhachHang"]);
                    item.SubItems.Add((string)doc["NgayBatDau"]);
                    item.SubItems.Add((string)doc["NgayKetThuc"]);
                    item.SubItems.Add(((Int64)doc["GiaThue"]).ToString());
                    item.SubItems.Add((string)doc["TienCoc"]);
                    item.SubItems.Add(((Int64)doc["SoNguoiO"]).ToString());
                    this.mlvHopDong.Items.Add(item);
                }
            }
        }

        //Lấy danh sách hợp đồng đang chọn
        private ListViewItem[] layDanhSachChonHopDong()
        {
            List<ListViewItem> danhSachHopDong = new List<ListViewItem>();
            foreach (ListViewItem hopDong in mlvHopDong.SelectedItems)
            {
                danhSachHopDong.Add(hopDong);
            }
            return danhSachHopDong.ToArray();
        }

        private void them_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Run(() =>
                {
                    ThemHopDong themHopDong = new ThemHopDong();
                    themHopDong.ShowDialog();
                });

            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {

        }

        private void xoa_Click(object sender, EventArgs e)
        {

        }
    }
}
