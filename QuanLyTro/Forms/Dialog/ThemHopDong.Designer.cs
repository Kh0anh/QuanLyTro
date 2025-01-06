namespace QuanLyTro.Forms.Dialog
{
    partial class ThemHopDong
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
            this.grpThemHopDong = new System.Windows.Forms.GroupBox();
            this.mtbNgayBatDau = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.mtbNgayKetThuc = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.mtbGiaThue = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.mTienCoc = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.mcbSoNguoiO = new ReaLTaiizor.Controls.MaterialComboBox();
            this.materialComboBox1 = new ReaLTaiizor.Controls.MaterialComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.grpThemHopDong.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpThemHopDong
            // 
            this.grpThemHopDong.Controls.Add(this.dateTimePicker1);
            this.grpThemHopDong.Controls.Add(this.materialComboBox1);
            this.grpThemHopDong.Controls.Add(this.mcbSoNguoiO);
            this.grpThemHopDong.Controls.Add(this.mTienCoc);
            this.grpThemHopDong.Controls.Add(this.mtbGiaThue);
            this.grpThemHopDong.Controls.Add(this.mtbNgayKetThuc);
            this.grpThemHopDong.Controls.Add(this.mtbNgayBatDau);
            this.grpThemHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThemHopDong.Location = new System.Drawing.Point(8, 33);
            this.grpThemHopDong.Margin = new System.Windows.Forms.Padding(4);
            this.grpThemHopDong.Name = "grpThemHopDong";
            this.grpThemHopDong.Padding = new System.Windows.Forms.Padding(4);
            this.grpThemHopDong.Size = new System.Drawing.Size(517, 501);
            this.grpThemHopDong.TabIndex = 15;
            this.grpThemHopDong.TabStop = false;
            this.grpThemHopDong.Text = "Thông Tin Hợp Đồng";
            // 
            // mtbNgayBatDau
            // 
            this.mtbNgayBatDau.AnimateReadOnly = false;
            this.mtbNgayBatDau.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.mtbNgayBatDau.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.mtbNgayBatDau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtbNgayBatDau.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtbNgayBatDau.Depth = 0;
            this.mtbNgayBatDau.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbNgayBatDau.HideSelection = true;
            this.mtbNgayBatDau.Hint = "Ngày Bắt Đầu";
            this.mtbNgayBatDau.LeadingIcon = null;
            this.mtbNgayBatDau.Location = new System.Drawing.Point(7, 83);
            this.mtbNgayBatDau.MaxLength = 32767;
            this.mtbNgayBatDau.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.mtbNgayBatDau.Name = "mtbNgayBatDau";
            this.mtbNgayBatDau.PasswordChar = '\0';
            this.mtbNgayBatDau.PrefixSuffixText = null;
            this.mtbNgayBatDau.ReadOnly = false;
            this.mtbNgayBatDau.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbNgayBatDau.SelectedText = "";
            this.mtbNgayBatDau.SelectionLength = 0;
            this.mtbNgayBatDau.SelectionStart = 0;
            this.mtbNgayBatDau.ShortcutsEnabled = true;
            this.mtbNgayBatDau.Size = new System.Drawing.Size(250, 48);
            this.mtbNgayBatDau.TabIndex = 0;
            this.mtbNgayBatDau.TabStop = false;
            this.mtbNgayBatDau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtbNgayBatDau.TrailingIcon = null;
            this.mtbNgayBatDau.UseSystemPasswordChar = false;
            // 
            // mtbNgayKetThuc
            // 
            this.mtbNgayKetThuc.AnimateReadOnly = false;
            this.mtbNgayKetThuc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.mtbNgayKetThuc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.mtbNgayKetThuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtbNgayKetThuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtbNgayKetThuc.Depth = 0;
            this.mtbNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbNgayKetThuc.HideSelection = true;
            this.mtbNgayKetThuc.Hint = "Ngày Kết Thúc";
            this.mtbNgayKetThuc.LeadingIcon = null;
            this.mtbNgayKetThuc.Location = new System.Drawing.Point(8, 137);
            this.mtbNgayKetThuc.MaxLength = 32767;
            this.mtbNgayKetThuc.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.mtbNgayKetThuc.Name = "mtbNgayKetThuc";
            this.mtbNgayKetThuc.PasswordChar = '\0';
            this.mtbNgayKetThuc.PrefixSuffixText = null;
            this.mtbNgayKetThuc.ReadOnly = false;
            this.mtbNgayKetThuc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbNgayKetThuc.SelectedText = "";
            this.mtbNgayKetThuc.SelectionLength = 0;
            this.mtbNgayKetThuc.SelectionStart = 0;
            this.mtbNgayKetThuc.ShortcutsEnabled = true;
            this.mtbNgayKetThuc.Size = new System.Drawing.Size(250, 48);
            this.mtbNgayKetThuc.TabIndex = 1;
            this.mtbNgayKetThuc.TabStop = false;
            this.mtbNgayKetThuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtbNgayKetThuc.TrailingIcon = null;
            this.mtbNgayKetThuc.UseSystemPasswordChar = false;
            // 
            // mtbGiaThue
            // 
            this.mtbGiaThue.AnimateReadOnly = false;
            this.mtbGiaThue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.mtbGiaThue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.mtbGiaThue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtbGiaThue.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtbGiaThue.Depth = 0;
            this.mtbGiaThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbGiaThue.HideSelection = true;
            this.mtbGiaThue.Hint = "Giá Thuê";
            this.mtbGiaThue.LeadingIcon = null;
            this.mtbGiaThue.Location = new System.Drawing.Point(7, 191);
            this.mtbGiaThue.MaxLength = 32767;
            this.mtbGiaThue.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.mtbGiaThue.Name = "mtbGiaThue";
            this.mtbGiaThue.PasswordChar = '\0';
            this.mtbGiaThue.PrefixSuffixText = null;
            this.mtbGiaThue.ReadOnly = false;
            this.mtbGiaThue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbGiaThue.SelectedText = "";
            this.mtbGiaThue.SelectionLength = 0;
            this.mtbGiaThue.SelectionStart = 0;
            this.mtbGiaThue.ShortcutsEnabled = true;
            this.mtbGiaThue.Size = new System.Drawing.Size(250, 48);
            this.mtbGiaThue.TabIndex = 2;
            this.mtbGiaThue.TabStop = false;
            this.mtbGiaThue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtbGiaThue.TrailingIcon = null;
            this.mtbGiaThue.UseSystemPasswordChar = false;
            // 
            // mTienCoc
            // 
            this.mTienCoc.AnimateReadOnly = false;
            this.mTienCoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.mTienCoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.mTienCoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mTienCoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mTienCoc.Depth = 0;
            this.mTienCoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mTienCoc.HideSelection = true;
            this.mTienCoc.Hint = "Tiền Cọc";
            this.mTienCoc.LeadingIcon = null;
            this.mTienCoc.Location = new System.Drawing.Point(7, 245);
            this.mTienCoc.MaxLength = 32767;
            this.mTienCoc.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.mTienCoc.Name = "mTienCoc";
            this.mTienCoc.PasswordChar = '\0';
            this.mTienCoc.PrefixSuffixText = null;
            this.mTienCoc.ReadOnly = false;
            this.mTienCoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTienCoc.SelectedText = "";
            this.mTienCoc.SelectionLength = 0;
            this.mTienCoc.SelectionStart = 0;
            this.mTienCoc.ShortcutsEnabled = true;
            this.mTienCoc.Size = new System.Drawing.Size(250, 48);
            this.mTienCoc.TabIndex = 3;
            this.mTienCoc.TabStop = false;
            this.mTienCoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mTienCoc.TrailingIcon = null;
            this.mTienCoc.UseSystemPasswordChar = false;
            // 
            // mcbSoNguoiO
            // 
            this.mcbSoNguoiO.AutoResize = false;
            this.mcbSoNguoiO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcbSoNguoiO.Depth = 0;
            this.mcbSoNguoiO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mcbSoNguoiO.DropDownHeight = 174;
            this.mcbSoNguoiO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mcbSoNguoiO.DropDownWidth = 121;
            this.mcbSoNguoiO.Font = new System.Drawing.Font("Sans Serif Collection", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcbSoNguoiO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcbSoNguoiO.FormattingEnabled = true;
            this.mcbSoNguoiO.Hint = "Số Người Ở";
            this.mcbSoNguoiO.IntegralHeight = false;
            this.mcbSoNguoiO.ItemHeight = 43;
            this.mcbSoNguoiO.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.mcbSoNguoiO.Location = new System.Drawing.Point(8, 316);
            this.mcbSoNguoiO.Margin = new System.Windows.Forms.Padding(4);
            this.mcbSoNguoiO.MaxDropDownItems = 4;
            this.mcbSoNguoiO.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.mcbSoNguoiO.Name = "mcbSoNguoiO";
            this.mcbSoNguoiO.Size = new System.Drawing.Size(121, 49);
            this.mcbSoNguoiO.StartIndex = 0;
            this.mcbSoNguoiO.TabIndex = 10;
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.Hint = "Mã Khách Hàng";
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(8, 28);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(250, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(280, 108);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // ThemHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 542);
            this.Controls.Add(this.grpThemHopDong);
            this.FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            this.Name = "ThemHopDong";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.Text = "ThemHopDong";
            this.Load += new System.EventHandler(this.ThemHopDong_Load);
            this.grpThemHopDong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThemHopDong;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbNgayBatDau;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbNgayKetThuc;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbGiaThue;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit mTienCoc;
        private ReaLTaiizor.Controls.MaterialComboBox mcbSoNguoiO;
        private ReaLTaiizor.Controls.MaterialComboBox materialComboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}