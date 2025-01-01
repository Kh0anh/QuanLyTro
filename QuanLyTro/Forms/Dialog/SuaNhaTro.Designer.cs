namespace QuanLyTro.Forms.Dialog
{
    partial class SuaNhaTro
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
            this.txTenNhaTro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txDiaChi = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txGhiChu = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            this.btXacNhan = new ReaLTaiizor.Controls.MaterialButton();
            this.btHuy = new ReaLTaiizor.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txTenNhaTro
            // 
            this.txTenNhaTro.AnimateReadOnly = false;
            this.txTenNhaTro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txTenNhaTro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txTenNhaTro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txTenNhaTro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txTenNhaTro.Depth = 0;
            this.txTenNhaTro.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txTenNhaTro.HideSelection = true;
            this.txTenNhaTro.Hint = "Tên Nhà Trọ";
            this.txTenNhaTro.LeadingIcon = null;
            this.txTenNhaTro.Location = new System.Drawing.Point(20, 41);
            this.txTenNhaTro.MaxLength = 32767;
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
            this.txTenNhaTro.Size = new System.Drawing.Size(350, 48);
            this.txTenNhaTro.TabIndex = 0;
            this.txTenNhaTro.TabStop = false;
            this.txTenNhaTro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txTenNhaTro.TrailingIcon = null;
            this.txTenNhaTro.UseSystemPasswordChar = false;
            this.txTenNhaTro.TextChanged += new System.EventHandler(this.txTenNhaTro_TextChanged);
            // 
            // txDiaChi
            // 
            this.txDiaChi.AnimateReadOnly = false;
            this.txDiaChi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txDiaChi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txDiaChi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txDiaChi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txDiaChi.Depth = 0;
            this.txDiaChi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txDiaChi.HideSelection = true;
            this.txDiaChi.Hint = "Địa chỉ";
            this.txDiaChi.LeadingIcon = null;
            this.txDiaChi.Location = new System.Drawing.Point(20, 95);
            this.txDiaChi.MaxLength = 32767;
            this.txDiaChi.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txDiaChi.Name = "txDiaChi";
            this.txDiaChi.PasswordChar = '\0';
            this.txDiaChi.PrefixSuffixText = null;
            this.txDiaChi.ReadOnly = false;
            this.txDiaChi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txDiaChi.SelectedText = "";
            this.txDiaChi.SelectionLength = 0;
            this.txDiaChi.SelectionStart = 0;
            this.txDiaChi.ShortcutsEnabled = true;
            this.txDiaChi.Size = new System.Drawing.Size(350, 48);
            this.txDiaChi.TabIndex = 1;
            this.txDiaChi.TabStop = false;
            this.txDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txDiaChi.TrailingIcon = null;
            this.txDiaChi.UseSystemPasswordChar = false;
            this.txDiaChi.TextChanged += new System.EventHandler(this.txDiaChi_TextChanged);
            // 
            // txGhiChu
            // 
            this.txGhiChu.AnimateReadOnly = false;
            this.txGhiChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txGhiChu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txGhiChu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txGhiChu.Depth = 0;
            this.txGhiChu.HideSelection = true;
            this.txGhiChu.Hint = "Ghi Chú";
            this.txGhiChu.Location = new System.Drawing.Point(20, 149);
            this.txGhiChu.MaxLength = 32767;
            this.txGhiChu.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txGhiChu.Name = "txGhiChu";
            this.txGhiChu.PasswordChar = '\0';
            this.txGhiChu.ReadOnly = false;
            this.txGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txGhiChu.SelectedText = "";
            this.txGhiChu.SelectionLength = 0;
            this.txGhiChu.SelectionStart = 0;
            this.txGhiChu.ShortcutsEnabled = true;
            this.txGhiChu.Size = new System.Drawing.Size(350, 170);
            this.txGhiChu.TabIndex = 2;
            this.txGhiChu.TabStop = false;
            this.txGhiChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txGhiChu.UseSystemPasswordChar = false;
            this.txGhiChu.TextChanged += new System.EventHandler(this.txGhiChu_TextChanged);
            // 
            // btXacNhan
            // 
            this.btXacNhan.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btXacNhan.Depth = 0;
            this.btXacNhan.HighEmphasis = true;
            this.btXacNhan.Icon = null;
            this.btXacNhan.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btXacNhan.Location = new System.Drawing.Point(270, 343);
            this.btXacNhan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btXacNhan.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btXacNhan.Name = "btXacNhan";
            this.btXacNhan.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btXacNhan.Size = new System.Drawing.Size(100, 36);
            this.btXacNhan.TabIndex = 3;
            this.btXacNhan.Text = "Xác Nhận";
            this.btXacNhan.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btXacNhan.UseAccentColor = false;
            this.btXacNhan.UseVisualStyleBackColor = true;
            this.btXacNhan.Click += new System.EventHandler(this.btXacNhan_Click);
            // 
            // btHuy
            // 
            this.btHuy.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btHuy.Depth = 0;
            this.btHuy.HighEmphasis = true;
            this.btHuy.Icon = null;
            this.btHuy.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btHuy.Location = new System.Drawing.Point(162, 343);
            this.btHuy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btHuy.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btHuy.Name = "btHuy";
            this.btHuy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btHuy.Size = new System.Drawing.Size(100, 36);
            this.btHuy.TabIndex = 4;
            this.btHuy.Text = "Huỷ";
            this.btHuy.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btHuy.UseAccentColor = true;
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // SuaNhaTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btXacNhan);
            this.Controls.Add(this.txGhiChu);
            this.Controls.Add(this.txDiaChi);
            this.Controls.Add(this.txTenNhaTro);
            this.FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            this.Name = "SuaNhaTro";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "SuaNhaTro";
            this.Load += new System.EventHandler(this.SuaNhaTro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.MaterialButton btXacNhan;
        private ReaLTaiizor.Controls.MaterialButton btHuy;
        public ReaLTaiizor.Controls.MaterialTextBoxEdit txTenNhaTro;
        public ReaLTaiizor.Controls.MaterialTextBoxEdit txDiaChi;
        public ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit txGhiChu;
    }
}