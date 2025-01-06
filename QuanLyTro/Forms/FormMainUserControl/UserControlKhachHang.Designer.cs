namespace QuanLyTro.Forms.FormMainUserControl
{
    partial class UserControlKhachHang
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
            this.toolXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolThem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolXemChiTiet = new System.Windows.Forms.ToolStripMenuItem();
            this.cmKhachHang = new ReaLTaiizor.Controls.MaterialContextMenuStrip();
            this.toolSua = new System.Windows.Forms.ToolStripMenuItem();
            this.clGhiChu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSoCCCD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clGioTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clMa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvKhachHang = new ReaLTaiizor.Controls.MaterialListView();
            this.clNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txTenNhaTro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.btnThem = new System.Windows.Forms.Button();
            this.cmKhachHang.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolXoa
            // 
            this.toolXoa.Name = "toolXoa";
            this.toolXoa.Size = new System.Drawing.Size(115, 24);
            this.toolXoa.Text = "Xoá";
            // 
            // toolThem
            // 
            this.toolThem.Name = "toolThem";
            this.toolThem.Size = new System.Drawing.Size(115, 24);
            this.toolThem.Text = "Thêm";
            // 
            // toolXemChiTiet
            // 
            this.toolXemChiTiet.Name = "toolXemChiTiet";
            this.toolXemChiTiet.Size = new System.Drawing.Size(115, 24);
            this.toolXemChiTiet.Text = "Xem";
            // 
            // cmKhachHang
            // 
            this.cmKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmKhachHang.Depth = 0;
            this.cmKhachHang.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmKhachHang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolXemChiTiet,
            this.toolThem,
            this.toolSua,
            this.toolXoa});
            this.cmKhachHang.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.cmKhachHang.Name = "contextMenuStrip1";
            this.cmKhachHang.Size = new System.Drawing.Size(116, 100);
            // 
            // toolSua
            // 
            this.toolSua.Name = "toolSua";
            this.toolSua.Size = new System.Drawing.Size(115, 24);
            this.toolSua.Text = "Sửa";
            // 
            // clGhiChu
            // 
            this.clGhiChu.Text = "Ghi Chú";
            this.clGhiChu.Width = 240;
            // 
            // clSoCCCD
            // 
            this.clSoCCCD.Text = "Số CCCD";
            this.clSoCCCD.Width = 151;
            // 
            // clSDT
            // 
            this.clSDT.Text = "Số Điện Thoại";
            this.clSDT.Width = 133;
            // 
            // clGioTinh
            // 
            this.clGioTinh.Text = "Giớ Tính";
            this.clGioTinh.Width = 91;
            // 
            // clDiaChi
            // 
            this.clDiaChi.Text = "Địa Chỉ";
            this.clDiaChi.Width = 109;
            // 
            // clTen
            // 
            this.clTen.Text = "Họ Và Tên";
            this.clTen.Width = 134;
            // 
            // clMa
            // 
            this.clMa.Text = "Mã Khách Hành";
            this.clMa.Width = 135;
            // 
            // lvKhachHang
            // 
            this.lvKhachHang.AutoSizeTable = false;
            this.lvKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvKhachHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clMa,
            this.clTen,
            this.clDiaChi,
            this.clGioTinh,
            this.clNgaySinh,
            this.clSDT,
            this.clSoCCCD,
            this.clGhiChu});
            this.lvKhachHang.Depth = 0;
            this.lvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvKhachHang.FullRowSelect = true;
            this.lvKhachHang.HideSelection = false;
            this.lvKhachHang.Location = new System.Drawing.Point(0, 58);
            this.lvKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.lvKhachHang.MinimumSize = new System.Drawing.Size(267, 123);
            this.lvKhachHang.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvKhachHang.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.lvKhachHang.Name = "lvKhachHang";
            this.lvKhachHang.OwnerDraw = true;
            this.lvKhachHang.Size = new System.Drawing.Size(1067, 434);
            this.lvKhachHang.TabIndex = 4;
            this.lvKhachHang.UseCompatibleStateImageBehavior = false;
            this.lvKhachHang.View = System.Windows.Forms.View.Details;
            // 
            // clNgaySinh
            // 
            this.clNgaySinh.Text = "Ngày Sinh";
            this.clNgaySinh.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txTenNhaTro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 58);
            this.panel1.TabIndex = 3;
            // 
            // txTenNhaTro
            // 
            this.txTenNhaTro.AnimateReadOnly = false;
            this.txTenNhaTro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txTenNhaTro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txTenNhaTro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txTenNhaTro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txTenNhaTro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txTenNhaTro.Depth = 0;
            this.txTenNhaTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txTenNhaTro.HideSelection = true;
            this.txTenNhaTro.Hint = "Tên Khách Hàng hoặc Mã Khách Hàng";
            this.txTenNhaTro.LeadingIcon = null;
            this.txTenNhaTro.Location = new System.Drawing.Point(4, 6);
            this.txTenNhaTro.Margin = new System.Windows.Forms.Padding(4);
            this.txTenNhaTro.MaxLength = 32;
            this.txTenNhaTro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txTenNhaTro.Name = "txTenNhaTro";
            this.txTenNhaTro.PasswordChar = '\0';
            this.txTenNhaTro.PrefixSuffixText = null;
            this.txTenNhaTro.ReadOnly = false;
            this.txTenNhaTro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txTenNhaTro.SelectedText = "";
            this.txTenNhaTro.SelectionLength = 0;
            this.txTenNhaTro.SelectionStart = 0;
            this.txTenNhaTro.ShortcutsEnabled = true;
            this.txTenNhaTro.Size = new System.Drawing.Size(500, 48);
            this.txTenNhaTro.TabIndex = 14;
            this.txTenNhaTro.TabStop = false;
            this.txTenNhaTro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txTenNhaTro.TrailingIcon = null;
            this.txTenNhaTro.UseSystemPasswordChar = false;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(530, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 45);
            this.btnThem.TabIndex = 15;
            this.btnThem.TabStop = false;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // UserControlKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvKhachHang);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControlKhachHang";
            this.Size = new System.Drawing.Size(1067, 492);
            this.cmKhachHang.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem toolXoa;
        private System.Windows.Forms.ToolStripMenuItem toolThem;
        private System.Windows.Forms.ToolStripMenuItem toolXemChiTiet;
        private ReaLTaiizor.Controls.MaterialContextMenuStrip cmKhachHang;
        private System.Windows.Forms.ToolStripMenuItem toolSua;
        private System.Windows.Forms.ColumnHeader clGhiChu;
        private System.Windows.Forms.ColumnHeader clSoCCCD;
        private System.Windows.Forms.ColumnHeader clSDT;
        private System.Windows.Forms.ColumnHeader clGioTinh;
        private System.Windows.Forms.ColumnHeader clDiaChi;
        private System.Windows.Forms.ColumnHeader clTen;
        private System.Windows.Forms.ColumnHeader clMa;
        private ReaLTaiizor.Controls.MaterialListView lvKhachHang;
        private System.Windows.Forms.ColumnHeader clNgaySinh;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txTenNhaTro;
        private System.Windows.Forms.Button btnThem;
    }
}
