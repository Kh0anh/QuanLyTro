using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTro.Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text = CauHinh.TenPhanMem;

#if DEBUG
            ListViewItem item = new ListViewItem("PHONG-01");
            item.SubItems.Add("Thường");
            item.SubItems.Add("25.000.000.000 VNĐ");
            item.SubItems.Add("Thanh toán 26 ngày trước");
            item.SubItems.Add("Võ Nguyễn Gia Huy");
            item.SubItems.Add("Wifi (25.000 VNĐ), Rác (25.000 VNĐ)");
            item.SubItems.Add("2435");
            item.SubItems.Add("343");
            item.SubItems.Add("Phòng này ở rất sạch, thường xuyên đậu Ferrari trước cổng và đóng tiền đúng hạn!");
            this.listView1.Items.Add(item); 
#endif
        }

    }
}
