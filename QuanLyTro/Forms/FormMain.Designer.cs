namespace QuanLyTro.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tcMain = new ReaLTaiizor.Controls.MaterialTabControl();
            this.tabTrangChu = new System.Windows.Forms.TabPage();
            this.userControlTrangChu = new QuanLyTro.Forms.FormMainUserControl.UserControlTrangChu();
            this.tabNhaTro = new System.Windows.Forms.TabPage();
            this.userControlNhaTro = new QuanLyTro.Forms.FormMainUserControl.UserControlNhaTro();
            this.tabPhongTro = new System.Windows.Forms.TabPage();
            this.userControlPhongTro = new QuanLyTro.Forms.FormMainUserControl.UserControlPhongTro();
            this.tabThanhToan = new System.Windows.Forms.TabPage();
            this.tabKhachHang = new System.Windows.Forms.TabPage();
            this.userControlKhachHang = new QuanLyTro.Forms.FormMainUserControl.UserControlKhachHang();
            this.tabHopDong = new System.Windows.Forms.TabPage();
            this.userControlHopDong = new QuanLyTro.Forms.FormMainUserControl.UserControlHopDong();
            this.tabCauHinh = new System.Windows.Forms.TabPage();
            this.userControlCauHinh = new QuanLyTro.Forms.FormMainUserControl.UserControlCauHinh();
            this.tabControlIconList = new System.Windows.Forms.ImageList(this.components);
            this.tcMain.SuspendLayout();
            this.tabTrangChu.SuspendLayout();
            this.tabNhaTro.SuspendLayout();
            this.tabPhongTro.SuspendLayout();
            this.tabKhachHang.SuspendLayout();
            this.tabHopDong.SuspendLayout();
            this.tabCauHinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabTrangChu);
            this.tcMain.Controls.Add(this.tabNhaTro);
            this.tcMain.Controls.Add(this.tabPhongTro);
            this.tcMain.Controls.Add(this.tabThanhToan);
            this.tcMain.Controls.Add(this.tabKhachHang);
            this.tcMain.Controls.Add(this.tabHopDong);
            this.tcMain.Controls.Add(this.tabCauHinh);
            this.tcMain.Depth = 0;
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.ImageList = this.tabControlIconList;
            this.tcMain.Location = new System.Drawing.Point(0, 64);
            this.tcMain.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.tcMain.Multiline = true;
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1008, 427);
            this.tcMain.TabIndex = 0;
            // 
            // tabTrangChu
            // 
            this.tabTrangChu.Controls.Add(this.userControlTrangChu);
            this.tabTrangChu.ImageKey = "trangchu.png";
            this.tabTrangChu.Location = new System.Drawing.Point(4, 23);
            this.tabTrangChu.Name = "tabTrangChu";
            this.tabTrangChu.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrangChu.Size = new System.Drawing.Size(1000, 400);
            this.tabTrangChu.TabIndex = 0;
            this.tabTrangChu.Text = "Trang Chủ";
            this.tabTrangChu.UseVisualStyleBackColor = true;
            // 
            // userControlTrangChu
            // 
            this.userControlTrangChu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlTrangChu.Location = new System.Drawing.Point(3, 3);
            this.userControlTrangChu.Name = "userControlTrangChu";
            this.userControlTrangChu.Size = new System.Drawing.Size(994, 394);
            this.userControlTrangChu.TabIndex = 0;
            // 
            // tabNhaTro
            // 
            this.tabNhaTro.Controls.Add(this.userControlNhaTro);
            this.tabNhaTro.ImageKey = "nha.png";
            this.tabNhaTro.Location = new System.Drawing.Point(4, 23);
            this.tabNhaTro.Name = "tabNhaTro";
            this.tabNhaTro.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhaTro.Size = new System.Drawing.Size(1000, 400);
            this.tabNhaTro.TabIndex = 1;
            this.tabNhaTro.Text = "Nhà Trọ";
            this.tabNhaTro.UseVisualStyleBackColor = true;
            // 
            // userControlNhaTro
            // 
            this.userControlNhaTro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlNhaTro.Location = new System.Drawing.Point(3, 3);
            this.userControlNhaTro.Name = "userControlNhaTro";
            this.userControlNhaTro.Size = new System.Drawing.Size(994, 394);
            this.userControlNhaTro.TabIndex = 0;
            // 
            // tabPhongTro
            // 
            this.tabPhongTro.Controls.Add(this.userControlPhongTro);
            this.tabPhongTro.ImageKey = "cua.png";
            this.tabPhongTro.Location = new System.Drawing.Point(4, 23);
            this.tabPhongTro.Name = "tabPhongTro";
            this.tabPhongTro.Size = new System.Drawing.Size(1000, 400);
            this.tabPhongTro.TabIndex = 2;
            this.tabPhongTro.Text = "Phòng Trọ";
            this.tabPhongTro.UseVisualStyleBackColor = true;
            // 
            // userControlPhongTro
            // 
            this.userControlPhongTro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlPhongTro.Location = new System.Drawing.Point(0, 0);
            this.userControlPhongTro.Name = "userControlPhongTro";
            this.userControlPhongTro.Size = new System.Drawing.Size(1000, 400);
            this.userControlPhongTro.TabIndex = 0;
            // 
            // tabThanhToan
            // 
            this.tabThanhToan.ImageKey = "thanhtoan.png";
            this.tabThanhToan.Location = new System.Drawing.Point(4, 23);
            this.tabThanhToan.Name = "tabThanhToan";
            this.tabThanhToan.Size = new System.Drawing.Size(1000, 400);
            this.tabThanhToan.TabIndex = 6;
            this.tabThanhToan.Text = "Thanh Toán";
            this.tabThanhToan.UseVisualStyleBackColor = true;
            // 
            // tabKhachHang
            // 
            this.tabKhachHang.Controls.Add(this.userControlKhachHang);
            this.tabKhachHang.ImageKey = "khanghang.png";
            this.tabKhachHang.Location = new System.Drawing.Point(4, 23);
            this.tabKhachHang.Name = "tabKhachHang";
            this.tabKhachHang.Size = new System.Drawing.Size(1000, 400);
            this.tabKhachHang.TabIndex = 3;
            this.tabKhachHang.Text = "Khách Hàng";
            this.tabKhachHang.UseVisualStyleBackColor = true;
            // 
            // userControlKhachHang
            // 
            this.userControlKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlKhachHang.Location = new System.Drawing.Point(0, 0);
            this.userControlKhachHang.Name = "userControlKhachHang";
            this.userControlKhachHang.Size = new System.Drawing.Size(1000, 400);
            this.userControlKhachHang.TabIndex = 0;
            // 
            // tabHopDong
            // 
            this.tabHopDong.Controls.Add(this.userControlHopDong);
            this.tabHopDong.ImageKey = "hopdong.png";
            this.tabHopDong.Location = new System.Drawing.Point(4, 23);
            this.tabHopDong.Name = "tabHopDong";
            this.tabHopDong.Size = new System.Drawing.Size(1000, 400);
            this.tabHopDong.TabIndex = 5;
            this.tabHopDong.Text = "Hợp Đồng";
            this.tabHopDong.UseVisualStyleBackColor = true;
            // 
            // userControlHopDong
            // 
            this.userControlHopDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlHopDong.Location = new System.Drawing.Point(0, 0);
            this.userControlHopDong.Name = "userControlHopDong";
            this.userControlHopDong.Size = new System.Drawing.Size(1000, 400);
            this.userControlHopDong.TabIndex = 0;
            // 
            // tabCauHinh
            // 
            this.tabCauHinh.Controls.Add(this.userControlCauHinh);
            this.tabCauHinh.ImageKey = "cauhinh.png";
            this.tabCauHinh.Location = new System.Drawing.Point(4, 23);
            this.tabCauHinh.Name = "tabCauHinh";
            this.tabCauHinh.Size = new System.Drawing.Size(1000, 400);
            this.tabCauHinh.TabIndex = 4;
            this.tabCauHinh.Text = "Cấu Hình";
            this.tabCauHinh.UseVisualStyleBackColor = true;
            // 
            // userControlCauHinh
            // 
            this.userControlCauHinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlCauHinh.Location = new System.Drawing.Point(0, 0);
            this.userControlCauHinh.Name = "userControlCauHinh";
            this.userControlCauHinh.Size = new System.Drawing.Size(1000, 400);
            this.userControlCauHinh.TabIndex = 0;
            // 
            // tabControlIconList
            // 
            this.tabControlIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tabControlIconList.ImageStream")));
            this.tabControlIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.tabControlIconList.Images.SetKeyName(0, "cua.png");
            this.tabControlIconList.Images.SetKeyName(1, "khanghang.png");
            this.tabControlIconList.Images.SetKeyName(2, "nha.png");
            this.tabControlIconList.Images.SetKeyName(3, "trangchu.png");
            this.tabControlIconList.Images.SetKeyName(4, "cauhinh.png");
            this.tabControlIconList.Images.SetKeyName(5, "hopdong.png");
            this.tabControlIconList.Images.SetKeyName(6, "thanhtoan.png");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 494);
            this.Controls.Add(this.tcMain);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tcMain;
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 3, 3);
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tcMain.ResumeLayout(false);
            this.tabTrangChu.ResumeLayout(false);
            this.tabNhaTro.ResumeLayout(false);
            this.tabPhongTro.ResumeLayout(false);
            this.tabKhachHang.ResumeLayout(false);
            this.tabHopDong.ResumeLayout(false);
            this.tabCauHinh.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl tcMain;
        private System.Windows.Forms.TabPage tabTrangChu;
        private System.Windows.Forms.TabPage tabNhaTro;
        private System.Windows.Forms.TabPage tabPhongTro;
        private System.Windows.Forms.TabPage tabKhachHang;
        private System.Windows.Forms.TabPage tabCauHinh;
        private System.Windows.Forms.ImageList tabControlIconList;
        private FormMainUserControl.UserControlTrangChu userControlTrangChu;
        private FormMainUserControl.UserControlPhongTro userControlPhongTro;
        private FormMainUserControl.UserControlKhachHang userControlKhachHang;
        private FormMainUserControl.UserControlCauHinh userControlCauHinh;
        private System.Windows.Forms.TabPage tabHopDong;
        private FormMainUserControl.UserControlHopDong userControlHopDong;
        private System.Windows.Forms.TabPage tabThanhToan;
        public FormMainUserControl.UserControlNhaTro userControlNhaTro;
    }
}