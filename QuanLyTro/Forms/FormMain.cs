using ReaLTaiizor.Forms;
using System;
using System.Windows.Forms;

namespace QuanLyTro.Forms
{
    public partial class FormMain : MaterialForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text = CauHinh.TenPhanMem;

            //#if DEBUG
            //            ListViewItem item = new ListViewItem("PHONG-01");
            //            item.SubItems.Add("Thường");
            //            item.SubItems.Add("2.500.000 VNĐ");
            //            item.SubItems.Add("Thanh toán 26 ngày trước");
            //            item.SubItems.Add("Võ Nguyễn Gia Huy");
            //            item.SubItems.Add("Wifi (25.000 VNĐ), Rác (25.000 VNĐ)");
            //            item.SubItems.Add("2435");
            //            item.SubItems.Add("343");
            //            item.SubItems.Add("phòng này ở hơi dơ");
            //            this.listView1.Items.Add(item); 
            //#endif
        }

    }
}
