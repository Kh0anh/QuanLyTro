using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
