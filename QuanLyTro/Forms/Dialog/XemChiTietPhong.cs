using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTro.Forms.Dialog
{
    public partial class XemChiTietPhong : MaterialForm
    {
        public XemChiTietPhong()
        {
            InitializeComponent();
        }

        private void XemChiTietPhong_Load(object sender, EventArgs e)
        {
            //Tạo tên form
            this.Text = string.Format("{0} - Xem Chi Tiết Phòng", CauHinh.TenPhanMem);
        }
    }
}
