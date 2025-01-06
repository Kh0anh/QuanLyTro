namespace QuanLyTro.Forms.Dialog
{
    partial class ThemKhachHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txbNgaySinh = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txbGhiChu = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            this.txbCCCD = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txbSDT = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txbDiaChi = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txbTenKH = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.materialTextBoxEdit1 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXacNhan = new ReaLTaiizor.Controls.MaterialButton();
            this.btnHuy = new ReaLTaiizor.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txbNgaySinh);
            this.groupBox1.Controls.Add(this.txbGhiChu);
            this.groupBox1.Controls.Add(this.txbCCCD);
            this.groupBox1.Controls.Add(this.txbSDT);
            this.groupBox1.Controls.Add(this.txbDiaChi);
            this.groupBox1.Controls.Add(this.txbTenKH);
            this.groupBox1.Controls.Add(this.materialTextBoxEdit1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(6, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 453);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm Khách Hàng";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(141, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 24);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(26, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 24);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nam";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txbNgaySinh
            // 
            this.txbNgaySinh.AllowPromptAsInput = true;
            this.txbNgaySinh.AnimateReadOnly = false;
            this.txbNgaySinh.AsciiOnly = false;
            this.txbNgaySinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txbNgaySinh.BeepOnError = false;
            this.txbNgaySinh.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txbNgaySinh.Depth = 0;
            this.txbNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbNgaySinh.HidePromptOnLeave = false;
            this.txbNgaySinh.HideSelection = true;
            this.txbNgaySinh.Hint = "Nhập ngày sinh";
            this.txbNgaySinh.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txbNgaySinh.LeadingIcon = null;
            this.txbNgaySinh.Location = new System.Drawing.Point(272, 26);
            this.txbNgaySinh.Mask = "00/00/0000";
            this.txbNgaySinh.MaxLength = 32767;
            this.txbNgaySinh.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txbNgaySinh.Name = "txbNgaySinh";
            this.txbNgaySinh.PasswordChar = '\0';
            this.txbNgaySinh.PrefixSuffixText = null;
            this.txbNgaySinh.PromptChar = '_';
            this.txbNgaySinh.ReadOnly = false;
            this.txbNgaySinh.RejectInputOnFirstFailure = false;
            this.txbNgaySinh.ResetOnPrompt = true;
            this.txbNgaySinh.ResetOnSpace = true;
            this.txbNgaySinh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbNgaySinh.SelectedText = "";
            this.txbNgaySinh.SelectionLength = 0;
            this.txbNgaySinh.SelectionStart = 0;
            this.txbNgaySinh.ShortcutsEnabled = true;
            this.txbNgaySinh.Size = new System.Drawing.Size(250, 48);
            this.txbNgaySinh.SkipLiterals = true;
            this.txbNgaySinh.TabIndex = 16;
            this.txbNgaySinh.TabStop = false;
            this.txbNgaySinh.Text = "  /  /";
            this.txbNgaySinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbNgaySinh.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txbNgaySinh.TrailingIcon = null;
            this.txbNgaySinh.UseSystemPasswordChar = false;
            this.txbNgaySinh.ValidatingType = null;
            // 
            // txbGhiChu
            // 
            this.txbGhiChu.AnimateReadOnly = false;
            this.txbGhiChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txbGhiChu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbGhiChu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbGhiChu.Depth = 0;
            this.txbGhiChu.HideSelection = true;
            this.txbGhiChu.Hint = "Ghi chú";
            this.txbGhiChu.Location = new System.Drawing.Point(12, 320);
            this.txbGhiChu.MaxLength = 32767;
            this.txbGhiChu.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txbGhiChu.Name = "txbGhiChu";
            this.txbGhiChu.PasswordChar = '\0';
            this.txbGhiChu.ReadOnly = false;
            this.txbGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbGhiChu.SelectedText = "";
            this.txbGhiChu.SelectionLength = 0;
            this.txbGhiChu.SelectionStart = 0;
            this.txbGhiChu.ShortcutsEnabled = true;
            this.txbGhiChu.Size = new System.Drawing.Size(525, 127);
            this.txbGhiChu.TabIndex = 15;
            this.txbGhiChu.TabStop = false;
            this.txbGhiChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbGhiChu.UseSystemPasswordChar = false;
            // 
            // txbCCCD
            // 
            this.txbCCCD.AnimateReadOnly = false;
            this.txbCCCD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbCCCD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbCCCD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txbCCCD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbCCCD.Depth = 0;
            this.txbCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbCCCD.HideSelection = true;
            this.txbCCCD.Hint = "Nhập CCCD";
            this.txbCCCD.LeadingIcon = null;
            this.txbCCCD.Location = new System.Drawing.Point(272, 179);
            this.txbCCCD.MaxLength = 32767;
            this.txbCCCD.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txbCCCD.Name = "txbCCCD";
            this.txbCCCD.PasswordChar = '\0';
            this.txbCCCD.PrefixSuffixText = null;
            this.txbCCCD.ReadOnly = false;
            this.txbCCCD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbCCCD.SelectedText = "";
            this.txbCCCD.SelectionLength = 0;
            this.txbCCCD.SelectionStart = 0;
            this.txbCCCD.ShortcutsEnabled = true;
            this.txbCCCD.Size = new System.Drawing.Size(250, 48);
            this.txbCCCD.TabIndex = 14;
            this.txbCCCD.TabStop = false;
            this.txbCCCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbCCCD.TrailingIcon = null;
            this.txbCCCD.UseSystemPasswordChar = false;
            // 
            // txbSDT
            // 
            this.txbSDT.AnimateReadOnly = false;
            this.txbSDT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbSDT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbSDT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txbSDT.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbSDT.Depth = 0;
            this.txbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbSDT.HideSelection = true;
            this.txbSDT.Hint = "Nhập số điện thoại";
            this.txbSDT.LeadingIcon = null;
            this.txbSDT.Location = new System.Drawing.Point(272, 101);
            this.txbSDT.MaxLength = 32767;
            this.txbSDT.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.PasswordChar = '\0';
            this.txbSDT.PrefixSuffixText = null;
            this.txbSDT.ReadOnly = false;
            this.txbSDT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbSDT.SelectedText = "";
            this.txbSDT.SelectionLength = 0;
            this.txbSDT.SelectionStart = 0;
            this.txbSDT.ShortcutsEnabled = true;
            this.txbSDT.Size = new System.Drawing.Size(250, 48);
            this.txbSDT.TabIndex = 13;
            this.txbSDT.TabStop = false;
            this.txbSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbSDT.TrailingIcon = null;
            this.txbSDT.UseSystemPasswordChar = false;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.AnimateReadOnly = false;
            this.txbDiaChi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbDiaChi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbDiaChi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txbDiaChi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbDiaChi.Depth = 0;
            this.txbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbDiaChi.HideSelection = true;
            this.txbDiaChi.Hint = "Nhập địa chỉ";
            this.txbDiaChi.LeadingIcon = null;
            this.txbDiaChi.Location = new System.Drawing.Point(6, 179);
            this.txbDiaChi.MaxLength = 32767;
            this.txbDiaChi.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.PasswordChar = '\0';
            this.txbDiaChi.PrefixSuffixText = null;
            this.txbDiaChi.ReadOnly = false;
            this.txbDiaChi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbDiaChi.SelectedText = "";
            this.txbDiaChi.SelectionLength = 0;
            this.txbDiaChi.SelectionStart = 0;
            this.txbDiaChi.ShortcutsEnabled = true;
            this.txbDiaChi.Size = new System.Drawing.Size(250, 48);
            this.txbDiaChi.TabIndex = 10;
            this.txbDiaChi.TabStop = false;
            this.txbDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbDiaChi.TrailingIcon = null;
            this.txbDiaChi.UseSystemPasswordChar = false;
            // 
            // txbTenKH
            // 
            this.txbTenKH.AnimateReadOnly = false;
            this.txbTenKH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbTenKH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbTenKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txbTenKH.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbTenKH.Depth = 0;
            this.txbTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbTenKH.HideSelection = true;
            this.txbTenKH.Hint = "Nhập tên khách hàng";
            this.txbTenKH.LeadingIcon = null;
            this.txbTenKH.Location = new System.Drawing.Point(6, 101);
            this.txbTenKH.MaxLength = 32767;
            this.txbTenKH.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txbTenKH.Name = "txbTenKH";
            this.txbTenKH.PasswordChar = '\0';
            this.txbTenKH.PrefixSuffixText = null;
            this.txbTenKH.ReadOnly = false;
            this.txbTenKH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbTenKH.SelectedText = "";
            this.txbTenKH.SelectionLength = 0;
            this.txbTenKH.SelectionStart = 0;
            this.txbTenKH.ShortcutsEnabled = true;
            this.txbTenKH.Size = new System.Drawing.Size(250, 48);
            this.txbTenKH.TabIndex = 9;
            this.txbTenKH.TabStop = false;
            this.txbTenKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbTenKH.TrailingIcon = null;
            this.txbTenKH.UseSystemPasswordChar = false;
            // 
            // materialTextBoxEdit1
            // 
            this.materialTextBoxEdit1.AnimateReadOnly = false;
            this.materialTextBoxEdit1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.materialTextBoxEdit1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.materialTextBoxEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxEdit1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxEdit1.Depth = 0;
            this.materialTextBoxEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxEdit1.HideSelection = true;
            this.materialTextBoxEdit1.Hint = "Mã Tự Động";
            this.materialTextBoxEdit1.LeadingIcon = null;
            this.materialTextBoxEdit1.Location = new System.Drawing.Point(6, 26);
            this.materialTextBoxEdit1.MaxLength = 32767;
            this.materialTextBoxEdit1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.materialTextBoxEdit1.Name = "materialTextBoxEdit1";
            this.materialTextBoxEdit1.PasswordChar = '\0';
            this.materialTextBoxEdit1.PrefixSuffixText = null;
            this.materialTextBoxEdit1.ReadOnly = false;
            this.materialTextBoxEdit1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxEdit1.SelectedText = "";
            this.materialTextBoxEdit1.SelectionLength = 0;
            this.materialTextBoxEdit1.SelectionStart = 0;
            this.materialTextBoxEdit1.ShortcutsEnabled = true;
            this.materialTextBoxEdit1.Size = new System.Drawing.Size(250, 48);
            this.materialTextBoxEdit1.TabIndex = 8;
            this.materialTextBoxEdit1.TabStop = false;
            this.materialTextBoxEdit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxEdit1.TrailingIcon = null;
            this.materialTextBoxEdit1.UseSystemPasswordChar = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Location = new System.Drawing.Point(6, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 58);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giới tính";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXacNhan.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXacNhan.Depth = 0;
            this.btnXacNhan.HighEmphasis = true;
            this.btnXacNhan.Icon = null;
            this.btnXacNhan.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnXacNhan.Location = new System.Drawing.Point(406, 546);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnXacNhan.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXacNhan.Size = new System.Drawing.Size(95, 36);
            this.btnXacNhan.TabIndex = 13;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXacNhan.UseAccentColor = false;
            this.btnXacNhan.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuy.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHuy.Depth = 0;
            this.btnHuy.HighEmphasis = true;
            this.btnHuy.Icon = null;
            this.btnHuy.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnHuy.Location = new System.Drawing.Point(310, 546);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnHuy.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuy.Size = new System.Drawing.Size(64, 36);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHuy.UseAccentColor = true;
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // ThemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 612);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThemKhachHang";
            this.Text = "ThemKhachHang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit txbGhiChu;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txbCCCD;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txbSDT;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txbDiaChi;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txbTenKH;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit1;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txbNgaySinh;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private ReaLTaiizor.Controls.MaterialButton btnXacNhan;
        private ReaLTaiizor.Controls.MaterialButton btnHuy;
    }
}