using ReaLTaiizor.Controls;
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
    public partial class ThemNhaTro : MaterialForm
    {
        public string TenNhaTro { get; set; }
        public int SoLuongPhong { get; set; }
        public string DiaChi { get; set; }
        public string GhiChu { get; set; }

        public ThemNhaTro()
        {
            InitializeComponent();
        }

        private void ThemNhaTro_Load(object sender, EventArgs e)
        {
            //Tạo tên form
            this.Text = string.Format("{0} - Thêm Nhà Trọ", CauHinh.TenPhanMem);
            
            //Khởi tạo giá trị mặt định cho biến
            SoLuongPhong = 0;
            DiaChi = string.Empty;
            GhiChu = string.Empty;
        }

        private void swTaoPhong_CheckedChanged(object sender, EventArgs e)
        {
            //Bật tắt comboBox Số Phòng
            if (swTaoPhong.Checked)
            {
                SoLuongPhong = comboSoPhong.SelectedIndex;
                comboSoPhong.Enabled = true;
            }
            else
            {
                SoLuongPhong = 0;
                comboSoPhong.Enabled = false;
            }
        }

        private void comboSoPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            SoLuongPhong = comboSoPhong.SelectedIndex; ;
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            //Trả về dialogResult = cancel và thoát
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void btXacNhan_Click(object sender, EventArgs e)
        {
            //Kiểm tra tên nhà trọ có trống không
            if (TenNhaTro == string.Empty)
            {
                MaterialMessageBox.Show("Tên nhà trọ không được để trống", "Lỗi", MessageBoxButtons.OK, MaterialFlexibleForm.ButtonsPosition.Right);
            }

            //Trả về dialogResult = OK và thoát
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txTenNhaTro_TextChanged(object sender, EventArgs e)
        {
            TenNhaTro = txTenNhaTro.Text;
        }

        private void txDiaChi_TextChanged(object sender, EventArgs e)
        {
            DiaChi = txDiaChi.Text;
        }

        private void txGhiChu_TextChanged(object sender, EventArgs e)
        {
            GhiChu = txGhiChu.Text;
        }
    }
}
