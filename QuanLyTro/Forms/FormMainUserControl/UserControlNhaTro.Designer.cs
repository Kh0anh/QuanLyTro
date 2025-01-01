using ReaLTaiizor.Controls;

namespace QuanLyTro.Forms.FormMainUserControl
{
    partial class UserControlNhaTro
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvNhaTro = new ReaLTaiizor.Controls.MaterialListView();
            this.clMaNhaTro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTenNhaTro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSoLuongPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clGhiChu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmLvNhaTro = new ReaLTaiizor.Controls.MaterialContextMenuStrip();
            this.them = new System.Windows.Forms.ToolStripMenuItem();
            this.sua = new System.Windows.Forms.ToolStripMenuItem();
            this.xoa = new System.Windows.Forms.ToolStripMenuItem();
            this.cmLvNhaTro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvNhaTro
            // 
            this.lvNhaTro.AutoSizeTable = false;
            this.lvNhaTro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvNhaTro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvNhaTro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clMaNhaTro,
            this.clTenNhaTro,
            this.clSoLuongPhong,
            this.clDiaChi,
            this.clGhiChu});
            this.lvNhaTro.ContextMenuStrip = this.cmLvNhaTro;
            this.lvNhaTro.Depth = 0;
            this.lvNhaTro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNhaTro.FullRowSelect = true;
            this.lvNhaTro.HideSelection = false;
            this.lvNhaTro.Location = new System.Drawing.Point(0, 0);
            this.lvNhaTro.MinimumSize = new System.Drawing.Size(200, 100);
            this.lvNhaTro.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvNhaTro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.lvNhaTro.Name = "lvNhaTro";
            this.lvNhaTro.OwnerDraw = true;
            this.lvNhaTro.Size = new System.Drawing.Size(800, 400);
            this.lvNhaTro.TabIndex = 0;
            this.lvNhaTro.UseCompatibleStateImageBehavior = false;
            this.lvNhaTro.View = System.Windows.Forms.View.Details;
            // 
            // clMaNhaTro
            // 
            this.clMaNhaTro.Text = "Mã";
            this.clMaNhaTro.Width = 120;
            // 
            // clTenNhaTro
            // 
            this.clTenNhaTro.Text = "Tên";
            this.clTenNhaTro.Width = 200;
            // 
            // clSoLuongPhong
            // 
            this.clSoLuongPhong.Text = "Số Lượng Phòng";
            this.clSoLuongPhong.Width = 140;
            // 
            // clDiaChi
            // 
            this.clDiaChi.Text = "Địa Chỉ";
            this.clDiaChi.Width = 240;
            // 
            // clGhiChu
            // 
            this.clGhiChu.Text = "Ghi Chú";
            this.clGhiChu.Width = 240;
            // 
            // cmLvNhaTro
            // 
            this.cmLvNhaTro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmLvNhaTro.Depth = 0;
            this.cmLvNhaTro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.them,
            this.sua,
            this.xoa});
            this.cmLvNhaTro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.cmLvNhaTro.Name = "contextMenuStrip1";
            this.cmLvNhaTro.Size = new System.Drawing.Size(181, 92);
            // 
            // them
            // 
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(105, 22);
            this.them.Text = "Thêm";
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // sua
            // 
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(180, 22);
            this.sua.Text = "Sửa";
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // xoa
            // 
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(180, 22);
            this.xoa.Text = "Xoá";
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // UserControlNhaTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvNhaTro);
            this.Name = "UserControlNhaTro";
            this.Size = new System.Drawing.Size(800, 400);
            this.Load += new System.EventHandler(this.UserControlNhaTro_Load);
            this.cmLvNhaTro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader clMaNhaTro;
        private System.Windows.Forms.ColumnHeader clTenNhaTro;
        private System.Windows.Forms.ColumnHeader clSoLuongPhong;
        private System.Windows.Forms.ColumnHeader clDiaChi;
        private System.Windows.Forms.ColumnHeader clGhiChu;
        private MaterialContextMenuStrip cmLvNhaTro;
        private System.Windows.Forms.ToolStripMenuItem them;
        private System.Windows.Forms.ToolStripMenuItem sua;
        private System.Windows.Forms.ToolStripMenuItem xoa;
        public MaterialListView lvNhaTro;
    }
}
