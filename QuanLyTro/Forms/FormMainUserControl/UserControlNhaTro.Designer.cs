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
            this.components = new System.ComponentModel.Container();
            this.lvNhaTro = new ReaLTaiizor.Controls.MaterialListView();
            this.clMaNhaTro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTenNhaTro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSoLuongPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTrangThaiNhaTro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new ReaLTaiizor.Controls.MaterialContextMenuStrip();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xoáToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
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
            this.clTrangThaiNhaTro});
            this.lvNhaTro.ContextMenuStrip = this.contextMenuStrip2;
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
            // clTrangThaiNhaTro
            // 
            this.clTrangThaiNhaTro.Text = "Trạng Thái";
            this.clTrangThaiNhaTro.Width = 240;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.contextMenuStrip1.Depth = 0;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.xoáToolStripMenuItem});
            this.contextMenuStrip1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 70);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.thêmToolStripMenuItem.Text = "Thêm";
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sửaToolStripMenuItem.Text = "Sửa";
            // 
            // xoáToolStripMenuItem
            // 
            this.xoáToolStripMenuItem.Name = "xoáToolStripMenuItem";
            this.xoáToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.xoáToolStripMenuItem.Text = "Xoá";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem1,
            this.sửaToolStripMenuItem1,
            this.xoáToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(105, 70);
            // 
            // thêmToolStripMenuItem1
            // 
            this.thêmToolStripMenuItem1.Name = "thêmToolStripMenuItem1";
            this.thêmToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.thêmToolStripMenuItem1.Text = "Thêm";
            // 
            // sửaToolStripMenuItem1
            // 
            this.sửaToolStripMenuItem1.Name = "sửaToolStripMenuItem1";
            this.sửaToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.sửaToolStripMenuItem1.Text = "Sửa";
            // 
            // xoáToolStripMenuItem1
            // 
            this.xoáToolStripMenuItem1.Name = "xoáToolStripMenuItem1";
            this.xoáToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.xoáToolStripMenuItem1.Text = "Xoá";
            // 
            // UserControlNhaTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvNhaTro);
            this.Name = "UserControlNhaTro";
            this.Size = new System.Drawing.Size(800, 400);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialListView lvNhaTro;
        private System.Windows.Forms.ColumnHeader clMaNhaTro;
        private System.Windows.Forms.ColumnHeader clTenNhaTro;
        private System.Windows.Forms.ColumnHeader clSoLuongPhong;
        private System.Windows.Forms.ColumnHeader clDiaChi;
        private System.Windows.Forms.ColumnHeader clTrangThaiNhaTro;
        private MaterialContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoáToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xoáToolStripMenuItem1;
    }
}
