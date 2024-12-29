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
            this.tabNhaTro = new System.Windows.Forms.TabPage();
            this.tabPhongTro = new System.Windows.Forms.TabPage();
            this.tabKhachHang = new System.Windows.Forms.TabPage();
            this.tabCauHinh = new System.Windows.Forms.TabPage();
            this.tabControlIconList = new System.Windows.Forms.ImageList(this.components);
            this.tcMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabTrangChu);
            this.tcMain.Controls.Add(this.tabNhaTro);
            this.tcMain.Controls.Add(this.tabPhongTro);
            this.tcMain.Controls.Add(this.tabKhachHang);
            this.tcMain.Controls.Add(this.tabCauHinh);
            this.tcMain.Depth = 0;
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.ImageList = this.tabControlIconList;
            this.tcMain.Location = new System.Drawing.Point(3, 64);
            this.tcMain.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.tcMain.Multiline = true;
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1005, 427);
            this.tcMain.TabIndex = 0;
            // 
            // tabTrangChu
            // 
            this.tabTrangChu.ImageKey = "trangchu.png";
            this.tabTrangChu.Location = new System.Drawing.Point(4, 23);
            this.tabTrangChu.Name = "tabTrangChu";
            this.tabTrangChu.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrangChu.Size = new System.Drawing.Size(997, 400);
            this.tabTrangChu.TabIndex = 0;
            this.tabTrangChu.Text = "Trang Chủ";
            this.tabTrangChu.UseVisualStyleBackColor = true;
            // 
            // tabNhaTro
            // 
            this.tabNhaTro.ImageKey = "nha.png";
            this.tabNhaTro.Location = new System.Drawing.Point(4, 23);
            this.tabNhaTro.Name = "tabNhaTro";
            this.tabNhaTro.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhaTro.Size = new System.Drawing.Size(997, 400);
            this.tabNhaTro.TabIndex = 1;
            this.tabNhaTro.Text = "Nhà Trọ";
            this.tabNhaTro.UseVisualStyleBackColor = true;
            // 
            // tabPhongTro
            // 
            this.tabPhongTro.ImageKey = "cua.png";
            this.tabPhongTro.Location = new System.Drawing.Point(4, 23);
            this.tabPhongTro.Name = "tabPhongTro";
            this.tabPhongTro.Size = new System.Drawing.Size(997, 400);
            this.tabPhongTro.TabIndex = 2;
            this.tabPhongTro.Text = "Phòng Trọ";
            this.tabPhongTro.UseVisualStyleBackColor = true;
            // 
            // tabKhachHang
            // 
            this.tabKhachHang.ImageKey = "khanghang.png";
            this.tabKhachHang.Location = new System.Drawing.Point(4, 23);
            this.tabKhachHang.Name = "tabKhachHang";
            this.tabKhachHang.Size = new System.Drawing.Size(997, 400);
            this.tabKhachHang.TabIndex = 3;
            this.tabKhachHang.Text = "Khách Hàng";
            this.tabKhachHang.UseVisualStyleBackColor = true;
            // 
            // tabCauHinh
            // 
            this.tabCauHinh.ImageKey = "cauhinh.png";
            this.tabCauHinh.Location = new System.Drawing.Point(4, 23);
            this.tabCauHinh.Name = "tabCauHinh";
            this.tabCauHinh.Size = new System.Drawing.Size(997, 400);
            this.tabCauHinh.TabIndex = 4;
            this.tabCauHinh.Text = "Cấu Hình";
            this.tabCauHinh.UseVisualStyleBackColor = true;
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
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 494);
            this.Controls.Add(this.tcMain);
            this.DrawerAutoShow = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tcMain;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tcMain.ResumeLayout(false);
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
    }
}