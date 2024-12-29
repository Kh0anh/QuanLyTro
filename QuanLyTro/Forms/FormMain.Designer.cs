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
            this.cardSoNhaTro = new ReaLTaiizor.Controls.MaterialCard();
            this.materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            this.materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            this.txSoNhaTro = new ReaLTaiizor.Controls.MaterialLabel();
            this.materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            this.materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            this.materialCard2 = new ReaLTaiizor.Controls.MaterialCard();
            this.materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            this.materialLabel5 = new ReaLTaiizor.Controls.MaterialLabel();
            this.materialCard3 = new ReaLTaiizor.Controls.MaterialCard();
            this.materialLabel6 = new ReaLTaiizor.Controls.MaterialLabel();
            this.materialLabel7 = new ReaLTaiizor.Controls.MaterialLabel();
            this.tcMain.SuspendLayout();
            this.tabTrangChu.SuspendLayout();
            this.cardSoNhaTro.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
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
            this.tabTrangChu.Controls.Add(this.materialCard3);
            this.tabTrangChu.Controls.Add(this.materialCard2);
            this.tabTrangChu.Controls.Add(this.materialCard1);
            this.tabTrangChu.Controls.Add(this.cardSoNhaTro);
            this.tabTrangChu.ImageKey = "trangchu.png";
            this.tabTrangChu.Location = new System.Drawing.Point(4, 23);
            this.tabTrangChu.Name = "tabTrangChu";
            this.tabTrangChu.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabTrangChu.Size = new System.Drawing.Size(1000, 400);
            this.tabTrangChu.TabIndex = 0;
            this.tabTrangChu.Text = "Trang Chủ";
            this.tabTrangChu.UseVisualStyleBackColor = true;
            // 
            // tabNhaTro
            // 
            this.tabNhaTro.ImageKey = "nha.png";
            this.tabNhaTro.Location = new System.Drawing.Point(4, 34);
            this.tabNhaTro.Name = "tabNhaTro";
            this.tabNhaTro.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabNhaTro.Size = new System.Drawing.Size(1000, 429);
            this.tabNhaTro.TabIndex = 1;
            this.tabNhaTro.Text = "Nhà Trọ";
            this.tabNhaTro.UseVisualStyleBackColor = true;
            // 
            // tabPhongTro
            // 
            this.tabPhongTro.ImageKey = "cua.png";
            this.tabPhongTro.Location = new System.Drawing.Point(4, 34);
            this.tabPhongTro.Name = "tabPhongTro";
            this.tabPhongTro.Size = new System.Drawing.Size(1000, 429);
            this.tabPhongTro.TabIndex = 2;
            this.tabPhongTro.Text = "Phòng Trọ";
            this.tabPhongTro.UseVisualStyleBackColor = true;
            // 
            // tabKhachHang
            // 
            this.tabKhachHang.ImageKey = "khanghang.png";
            this.tabKhachHang.Location = new System.Drawing.Point(4, 34);
            this.tabKhachHang.Name = "tabKhachHang";
            this.tabKhachHang.Size = new System.Drawing.Size(1000, 429);
            this.tabKhachHang.TabIndex = 3;
            this.tabKhachHang.Text = "Khách Hàng";
            this.tabKhachHang.UseVisualStyleBackColor = true;
            // 
            // tabCauHinh
            // 
            this.tabCauHinh.ImageKey = "cauhinh.png";
            this.tabCauHinh.Location = new System.Drawing.Point(4, 34);
            this.tabCauHinh.Name = "tabCauHinh";
            this.tabCauHinh.Size = new System.Drawing.Size(1000, 429);
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
            // cardSoNhaTro
            // 
            this.cardSoNhaTro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardSoNhaTro.Controls.Add(this.txSoNhaTro);
            this.cardSoNhaTro.Controls.Add(this.materialLabel4);
            this.cardSoNhaTro.Depth = 0;
            this.cardSoNhaTro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardSoNhaTro.Location = new System.Drawing.Point(17, 14);
            this.cardSoNhaTro.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.cardSoNhaTro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.cardSoNhaTro.Name = "cardSoNhaTro";
            this.cardSoNhaTro.Padding = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.cardSoNhaTro.Size = new System.Drawing.Size(170, 90);
            this.cardSoNhaTro.TabIndex = 0;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(215, 14);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.materialCard1.Size = new System.Drawing.Size(170, 90);
            this.materialCard1.TabIndex = 1;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            this.materialLabel4.HighEmphasis = true;
            this.materialLabel4.Location = new System.Drawing.Point(49, 14);
            this.materialLabel4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(67, 24);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "Nhà trọ";
            // 
            // txSoNhaTro
            // 
            this.txSoNhaTro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txSoNhaTro.AutoSize = true;
            this.txSoNhaTro.Depth = 0;
            this.txSoNhaTro.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txSoNhaTro.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            this.txSoNhaTro.HighEmphasis = true;
            this.txSoNhaTro.Location = new System.Drawing.Point(72, 47);
            this.txSoNhaTro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.txSoNhaTro.Name = "txSoNhaTro";
            this.txSoNhaTro.Size = new System.Drawing.Size(14, 29);
            this.txSoNhaTro.TabIndex = 2;
            this.txSoNhaTro.Text = "0";
            this.txSoNhaTro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            this.materialLabel1.HighEmphasis = true;
            this.materialLabel1.Location = new System.Drawing.Point(17, 14);
            this.materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(136, 24);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Tổng Số Phòng";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            this.materialLabel2.HighEmphasis = true;
            this.materialLabel2.Location = new System.Drawing.Point(76, 47);
            this.materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(14, 29);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "0";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialLabel3);
            this.materialCard2.Controls.Add(this.materialLabel5);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(413, 14);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(170, 90);
            this.materialCard2.TabIndex = 4;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            this.materialLabel3.HighEmphasis = true;
            this.materialLabel3.Location = new System.Drawing.Point(76, 47);
            this.materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(14, 29);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "0";
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            this.materialLabel5.HighEmphasis = true;
            this.materialLabel5.Location = new System.Drawing.Point(49, 14);
            this.materialLabel5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(67, 24);
            this.materialLabel5.TabIndex = 3;
            this.materialLabel5.Text = "Nhà trọ";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialLabel6);
            this.materialCard3.Controls.Add(this.materialLabel7);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(611, 14);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(170, 90);
            this.materialCard3.TabIndex = 5;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            this.materialLabel6.HighEmphasis = true;
            this.materialLabel6.Location = new System.Drawing.Point(76, 47);
            this.materialLabel6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(14, 29);
            this.materialLabel6.TabIndex = 3;
            this.materialLabel6.Text = "0";
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            this.materialLabel7.HighEmphasis = true;
            this.materialLabel7.Location = new System.Drawing.Point(49, 14);
            this.materialLabel7.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(67, 24);
            this.materialLabel7.TabIndex = 3;
            this.materialLabel7.Text = "Nhà trọ";
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
            this.Padding = new System.Windows.Forms.Padding(0, 64, 3, 3);
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tcMain.ResumeLayout(false);
            this.tabTrangChu.ResumeLayout(false);
            this.cardSoNhaTro.ResumeLayout(false);
            this.cardSoNhaTro.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
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
        private ReaLTaiizor.Controls.MaterialCard cardSoNhaTro;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private ReaLTaiizor.Controls.MaterialLabel txSoNhaTro;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialCard materialCard3;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel6;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel7;
        private ReaLTaiizor.Controls.MaterialCard materialCard2;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel5;
    }
}