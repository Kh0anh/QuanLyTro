using ReaLTaiizor.Controls;

namespace QuanLyTro.Forms.FormMainUserControl
{
    partial class UserControlPhongTro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbNhaTro = new ReaLTaiizor.Controls.MaterialComboBox();
            this.lvPhongTro = new ReaLTaiizor.Controls.MaterialListView();
            this.clMa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clToiDa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPhuPhi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSoDien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSoNuoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTrangThai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clKhachThue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clGhiChu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmPhongTro = new ReaLTaiizor.Controls.MaterialContextMenuStrip();
            this.toolThem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSua = new System.Windows.Forms.ToolStripMenuItem();
            this.toolXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolXemChiTiet = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.cmPhongTro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbNhaTro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 54);
            this.panel1.TabIndex = 1;
            // 
            // cbNhaTro
            // 
            this.cbNhaTro.AutoResize = false;
            this.cbNhaTro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbNhaTro.Depth = 0;
            this.cbNhaTro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbNhaTro.DropDownHeight = 174;
            this.cbNhaTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhaTro.DropDownWidth = 121;
            this.cbNhaTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbNhaTro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbNhaTro.FormattingEnabled = true;
            this.cbNhaTro.Hint = "Nhà Trọ";
            this.cbNhaTro.IntegralHeight = false;
            this.cbNhaTro.ItemHeight = 43;
            this.cbNhaTro.Location = new System.Drawing.Point(3, 3);
            this.cbNhaTro.MaxDropDownItems = 4;
            this.cbNhaTro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cbNhaTro.Name = "cbNhaTro";
            this.cbNhaTro.Size = new System.Drawing.Size(190, 49);
            this.cbNhaTro.StartIndex = 0;
            this.cbNhaTro.TabIndex = 1;
            // 
            // lvPhongTro
            // 
            this.lvPhongTro.AutoSizeTable = false;
            this.lvPhongTro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvPhongTro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvPhongTro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clMa,
            this.clGia,
            this.clToiDa,
            this.clPhuPhi,
            this.clSoDien,
            this.clSoNuoc,
            this.clTrangThai,
            this.clKhachThue,
            this.clGhiChu});
            this.lvPhongTro.Depth = 0;
            this.lvPhongTro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPhongTro.FullRowSelect = true;
            this.lvPhongTro.HideSelection = false;
            this.lvPhongTro.Location = new System.Drawing.Point(0, 54);
            this.lvPhongTro.MinimumSize = new System.Drawing.Size(200, 100);
            this.lvPhongTro.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvPhongTro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.lvPhongTro.Name = "lvPhongTro";
            this.lvPhongTro.OwnerDraw = true;
            this.lvPhongTro.Size = new System.Drawing.Size(800, 346);
            this.lvPhongTro.TabIndex = 2;
            this.lvPhongTro.UseCompatibleStateImageBehavior = false;
            this.lvPhongTro.View = System.Windows.Forms.View.Details;
            // 
            // clMa
            // 
            this.clMa.Text = "Mã Phòng";
            this.clMa.Width = 120;
            // 
            // clGia
            // 
            this.clGia.Text = "Giá";
            this.clGia.Width = 120;
            // 
            // clToiDa
            // 
            this.clToiDa.Text = "Người Ở Tối Đa";
            this.clToiDa.Width = 120;
            // 
            // clPhuPhi
            // 
            this.clPhuPhi.Text = "Phụ Phí";
            this.clPhuPhi.Width = 140;
            // 
            // clSoDien
            // 
            this.clSoDien.Text = "Số Điện";
            this.clSoDien.Width = 80;
            // 
            // clSoNuoc
            // 
            this.clSoNuoc.Text = "Số Nước";
            this.clSoNuoc.Width = 80;
            // 
            // clTrangThai
            // 
            this.clTrangThai.Text = "Trạng Thái";
            this.clTrangThai.Width = 140;
            // 
            // clKhachThue
            // 
            this.clKhachThue.Text = "Khách Thuê";
            this.clKhachThue.Width = 180;
            // 
            // clGhiChu
            // 
            this.clGhiChu.Text = "Ghi Chú";
            this.clGhiChu.Width = 240;
            // 
            // cmPhongTro
            // 
            this.cmPhongTro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmPhongTro.Depth = 0;
            this.cmPhongTro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolXemChiTiet,
            this.toolThem,
            this.toolSua,
            this.toolXoa});
            this.cmPhongTro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.cmPhongTro.Name = "contextMenuStrip1";
            this.cmPhongTro.Size = new System.Drawing.Size(181, 114);
            // 
            // toolThem
            // 
            this.toolThem.Name = "toolThem";
            this.toolThem.Size = new System.Drawing.Size(180, 22);
            this.toolThem.Text = "Thêm";
            // 
            // toolSua
            // 
            this.toolSua.Name = "toolSua";
            this.toolSua.Size = new System.Drawing.Size(180, 22);
            this.toolSua.Text = "Sửa";
            // 
            // toolXoa
            // 
            this.toolXoa.Name = "toolXoa";
            this.toolXoa.Size = new System.Drawing.Size(180, 22);
            this.toolXoa.Text = "Xoá";
            // 
            // toolXemChiTiet
            // 
            this.toolXemChiTiet.Name = "toolXemChiTiet";
            this.toolXemChiTiet.Size = new System.Drawing.Size(180, 22);
            this.toolXemChiTiet.Text = "Xem";
            // 
            // UserControlPhongTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvPhongTro);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlPhongTro";
            this.Size = new System.Drawing.Size(800, 400);
            this.panel1.ResumeLayout(false);
            this.cmPhongTro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.MaterialComboBox cbNhaTro;
        private ReaLTaiizor.Controls.MaterialListView lvPhongTro;
        private System.Windows.Forms.ColumnHeader clMa;
        private System.Windows.Forms.ColumnHeader clGia;
        private System.Windows.Forms.ColumnHeader clToiDa;
        private System.Windows.Forms.ColumnHeader clPhuPhi;
        private System.Windows.Forms.ColumnHeader clSoDien;
        private System.Windows.Forms.ColumnHeader clSoNuoc;
        private System.Windows.Forms.ColumnHeader clTrangThai;
        private System.Windows.Forms.ColumnHeader clKhachThue;
        private System.Windows.Forms.ColumnHeader clGhiChu;
        private MaterialContextMenuStrip cmPhongTro;
        private System.Windows.Forms.ToolStripMenuItem toolThem;
        private System.Windows.Forms.ToolStripMenuItem toolSua;
        private System.Windows.Forms.ToolStripMenuItem toolXoa;
        private System.Windows.Forms.ToolStripMenuItem toolXemChiTiet;
    }
}
