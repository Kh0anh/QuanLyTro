namespace QuanLyTro.Froms
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolThemPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTrangThai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNguoiThue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhuPhi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGhiChu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolThemPhongNhanh = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.txGiaDien = new System.Windows.Forms.ToolStripStatusLabel();
            this.txGiaNuoc = new System.Windows.Forms.ToolStripStatusLabel();
            this.colSoDien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoNuoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cấuHìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolPhong,
            this.cấuHìnhToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1011, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolPhong
            // 
            this.toolPhong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolThemPhong,
            this.toolThemPhongNhanh});
            this.toolPhong.Name = "toolPhong";
            this.toolPhong.Size = new System.Drawing.Size(54, 20);
            this.toolPhong.Text = "Phòng";
            // 
            // toolThemPhong
            // 
            this.toolThemPhong.Name = "toolThemPhong";
            this.toolThemPhong.Size = new System.Drawing.Size(181, 22);
            this.toolThemPhong.Text = "Thêm Phòng";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPhong,
            this.colLoai,
            this.colGia,
            this.colTrangThai,
            this.colNguoiThue,
            this.colPhuPhi,
            this.colSoDien,
            this.colSoNuoc,
            this.colGhiChu});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1011, 470);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colPhong
            // 
            this.colPhong.Text = "Phòng";
            // 
            // colLoai
            // 
            this.colLoai.Text = "Loại Phòng";
            this.colLoai.Width = 120;
            // 
            // colTrangThai
            // 
            this.colTrangThai.Text = "Trạng Thái";
            this.colTrangThai.Width = 120;
            // 
            // colNguoiThue
            // 
            this.colNguoiThue.Text = "Người Thuê";
            this.colNguoiThue.Width = 160;
            // 
            // colGia
            // 
            this.colGia.Text = "Giá";
            this.colGia.Width = 120;
            // 
            // colPhuPhi
            // 
            this.colPhuPhi.Text = "Phụ Phí";
            this.colPhuPhi.Width = 220;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Text = "Ghi Chú";
            this.colGhiChu.Width = 260;
            // 
            // toolThemPhongNhanh
            // 
            this.toolThemPhongNhanh.Name = "toolThemPhongNhanh";
            this.toolThemPhongNhanh.Size = new System.Drawing.Size(181, 22);
            this.toolThemPhongNhanh.Text = "Thêm Phòng Nhanh";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txGiaDien,
            this.txGiaNuoc});
            this.statusStrip.Location = new System.Drawing.Point(0, 472);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1011, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // txGiaDien
            // 
            this.txGiaDien.Name = "txGiaDien";
            this.txGiaDien.Size = new System.Drawing.Size(90, 17);
            this.txGiaDien.Text = "Giá Điện: 0 VNĐ";
            // 
            // txGiaNuoc
            // 
            this.txGiaNuoc.Name = "txGiaNuoc";
            this.txGiaNuoc.Size = new System.Drawing.Size(95, 17);
            this.txGiaNuoc.Text = "Giá Nước: 0 VNĐ";
            // 
            // colSoDien
            // 
            this.colSoDien.Text = "Số Điện";
            this.colSoDien.Width = 90;
            // 
            // colSoNuoc
            // 
            this.colSoNuoc.Text = "Số Nước";
            this.colSoNuoc.Width = 90;
            // 
            // cấuHìnhToolStripMenuItem
            // 
            this.cấuHìnhToolStripMenuItem.Name = "cấuHìnhToolStripMenuItem";
            this.cấuHìnhToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cấuHìnhToolStripMenuItem.Text = "Cấu Hình";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 494);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolPhong;
        private System.Windows.Forms.ToolStripMenuItem toolThemPhong;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colPhong;
        private System.Windows.Forms.ColumnHeader colLoai;
        private System.Windows.Forms.ColumnHeader colGia;
        private System.Windows.Forms.ColumnHeader colTrangThai;
        private System.Windows.Forms.ColumnHeader colNguoiThue;
        private System.Windows.Forms.ColumnHeader colPhuPhi;
        private System.Windows.Forms.ColumnHeader colGhiChu;
        private System.Windows.Forms.ToolStripMenuItem toolThemPhongNhanh;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel txGiaDien;
        private System.Windows.Forms.ToolStripStatusLabel txGiaNuoc;
        private System.Windows.Forms.ColumnHeader colSoDien;
        private System.Windows.Forms.ColumnHeader colSoNuoc;
        private System.Windows.Forms.ToolStripMenuItem cấuHìnhToolStripMenuItem;
    }
}