namespace QuanLyTro.Forms.FormMainUserControl
{
    partial class UserControlHopDong
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
            this.mcbHopDong = new ReaLTaiizor.Controls.MaterialComboBox();
            this.mlvHopDong = new ReaLTaiizor.Controls.MaterialListView();
            this.colMaHopDong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaKhachHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayBatDau = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayKetThuc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGiaThue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTienCoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoNguoiO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsHopDong = new ReaLTaiizor.Controls.MaterialContextMenuStrip();
            this.xem = new System.Windows.Forms.ToolStripMenuItem();
            this.them = new System.Windows.Forms.ToolStripMenuItem();
            this.sua = new System.Windows.Forms.ToolStripMenuItem();
            this.xoa = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsHopDong.SuspendLayout();
            this.SuspendLayout();
            // 
            // mcbHopDong
            // 
            this.mcbHopDong.AutoResize = false;
            this.mcbHopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcbHopDong.Depth = 0;
            this.mcbHopDong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mcbHopDong.DropDownHeight = 174;
            this.mcbHopDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mcbHopDong.DropDownWidth = 121;
            this.mcbHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mcbHopDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcbHopDong.FormattingEnabled = true;
            this.mcbHopDong.Hint = "Nhà Trọ";
            this.mcbHopDong.IntegralHeight = false;
            this.mcbHopDong.ItemHeight = 43;
            this.mcbHopDong.Location = new System.Drawing.Point(4, 4);
            this.mcbHopDong.Margin = new System.Windows.Forms.Padding(4);
            this.mcbHopDong.MaxDropDownItems = 4;
            this.mcbHopDong.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.mcbHopDong.Name = "mcbHopDong";
            this.mcbHopDong.Size = new System.Drawing.Size(252, 49);
            this.mcbHopDong.StartIndex = 0;
            this.mcbHopDong.TabIndex = 0;
            // 
            // mlvHopDong
            // 
            this.mlvHopDong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mlvHopDong.AutoSizeTable = false;
            this.mlvHopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mlvHopDong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvHopDong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHopDong,
            this.colMaKhachHang,
            this.colNgayBatDau,
            this.colNgayKetThuc,
            this.colGiaThue,
            this.colTienCoc,
            this.colSoNguoiO});
            this.mlvHopDong.ContextMenuStrip = this.cmsHopDong;
            this.mlvHopDong.Depth = 0;
            this.mlvHopDong.FullRowSelect = true;
            this.mlvHopDong.HideSelection = false;
            this.mlvHopDong.Location = new System.Drawing.Point(0, 66);
            this.mlvHopDong.Margin = new System.Windows.Forms.Padding(4);
            this.mlvHopDong.MinimumSize = new System.Drawing.Size(267, 123);
            this.mlvHopDong.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvHopDong.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.mlvHopDong.Name = "mlvHopDong";
            this.mlvHopDong.OwnerDraw = true;
            this.mlvHopDong.Size = new System.Drawing.Size(1067, 426);
            this.mlvHopDong.TabIndex = 1;
            this.mlvHopDong.UseCompatibleStateImageBehavior = false;
            this.mlvHopDong.View = System.Windows.Forms.View.Details;
            // 
            // colMaHopDong
            // 
            this.colMaHopDong.Text = "Mã Hợp Đồng";
            this.colMaHopDong.Width = 116;
            // 
            // colMaKhachHang
            // 
            this.colMaKhachHang.Text = "Mã Khách Hàng";
            this.colMaKhachHang.Width = 131;
            // 
            // colNgayBatDau
            // 
            this.colNgayBatDau.Text = "Ngày Bắt Đầu";
            this.colNgayBatDau.Width = 117;
            // 
            // colNgayKetThuc
            // 
            this.colNgayKetThuc.Text = "Ngày Kết Thúc";
            this.colNgayKetThuc.Width = 125;
            // 
            // colGiaThue
            // 
            this.colGiaThue.Text = "Giá Thuê";
            this.colGiaThue.Width = 200;
            // 
            // colTienCoc
            // 
            this.colTienCoc.Text = "Tiền Cọc";
            this.colTienCoc.Width = 200;
            // 
            // colSoNguoiO
            // 
            this.colSoNguoiO.Text = "Số Người Ở";
            this.colSoNguoiO.Width = 120;
            // 
            // cmsHopDong
            // 
            this.cmsHopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmsHopDong.Depth = 0;
            this.cmsHopDong.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsHopDong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xem,
            this.them,
            this.sua,
            this.xoa});
            this.cmsHopDong.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.cmsHopDong.Name = "contextMenuStrip1";
            this.cmsHopDong.Size = new System.Drawing.Size(116, 100);
            // 
            // xem
            // 
            this.xem.Name = "xem";
            this.xem.Size = new System.Drawing.Size(115, 24);
            this.xem.Text = "Xem";
            // 
            // them
            // 
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(115, 24);
            this.them.Text = "Thêm";
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // sua
            // 
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(115, 24);
            this.sua.Text = "Sửa";
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // xoa
            // 
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(115, 24);
            this.xoa.Text = "Xoá";
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // UserControlHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mlvHopDong);
            this.Controls.Add(this.mcbHopDong);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlHopDong";
            this.Size = new System.Drawing.Size(1067, 492);
            this.Load += new System.EventHandler(this.UserControlHopDong_Load);
            this.cmsHopDong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox mcbHopDong;
        private ReaLTaiizor.Controls.MaterialListView mlvHopDong;
        private System.Windows.Forms.ColumnHeader colMaHopDong;
        private System.Windows.Forms.ColumnHeader colMaKhachHang;
        private System.Windows.Forms.ColumnHeader colNgayBatDau;
        private System.Windows.Forms.ColumnHeader colNgayKetThuc;
        private System.Windows.Forms.ColumnHeader colGiaThue;
        private System.Windows.Forms.ColumnHeader colTienCoc;
        private System.Windows.Forms.ColumnHeader colSoNguoiO;
        private ReaLTaiizor.Controls.MaterialContextMenuStrip cmsHopDong;
        private System.Windows.Forms.ToolStripMenuItem xem;
        private System.Windows.Forms.ToolStripMenuItem them;
        private System.Windows.Forms.ToolStripMenuItem sua;
        private System.Windows.Forms.ToolStripMenuItem xoa;
    }
}
