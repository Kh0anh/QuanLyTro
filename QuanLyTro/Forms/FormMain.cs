using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System;

namespace QuanLyTro.Forms
{
    public partial class FormMain : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public FormMain()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;

            materialSkinManager.AddFormToManage(this);

            materialSkinManager.ColorScheme = new MaterialColorScheme(
                        MaterialPrimary.BlueGrey800,
                        MaterialPrimary.BlueGrey900,
                        MaterialPrimary.BlueGrey500,
                        MaterialAccent.LightBlue200,
                        MaterialTextShade.LIGHT);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text = CauHinh.TenPhanMem;
            //this.txSoNhaTro.Text = "100

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
