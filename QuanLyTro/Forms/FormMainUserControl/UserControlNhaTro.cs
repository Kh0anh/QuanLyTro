using QuanLyTro.Forms.Dialog;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace QuanLyTro.Forms.FormMainUserControl
{
    public partial class UserControlNhaTro : UserControl
    {
        public UserControlNhaTro()
        {
            InitializeComponent();

#if DEBUG
            ListViewItem item = new ListViewItem("TRO-1");
            item.SubItems.Add("Trọ Mango");
            item.SubItems.Add("58");
            item.SubItems.Add("278D Tạ Thị Phi, Long Tuyền, Quận Bình Thuỷ, Cần Thơ");
            item.SubItems.Add("Hoạt Động");
            this.lvNhaTro.Items.Add(item);
#endif
        }

        private void them_Click(object sender, EventArgs e)
        {
            ThemNhaTro themNhaTro = new ThemNhaTro();
            if (themNhaTro.ShowDialog() == DialogResult.OK)
            {
                Debug.WriteLine(string.Format("Đã thêm trọ với thông tin \nTên trọ: {0}\nĐịa chỉ: {1}\nGhi chú:{2}\nSố lượng phòng: {3}", themNhaTro.TenNhaTro, themNhaTro.DiaChi, themNhaTro.GhiChu, themNhaTro.SoLuongPhong.ToString()));
                ListViewItem item = new ListViewItem("TRO-2");
                item.SubItems.Add(themNhaTro.TenNhaTro);
                item.SubItems.Add(themNhaTro.SoLuongPhong.ToString());
                item.SubItems.Add(themNhaTro.DiaChi);
                item.SubItems.Add("Hoạt Động");
                this.lvNhaTro.Items.Add(item);
            }
            else
            {
                Debug.WriteLine("Thêm trọ bị huỷ!");
            }
        }
    }
}
