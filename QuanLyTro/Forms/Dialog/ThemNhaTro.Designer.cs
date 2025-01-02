namespace QuanLyTro.Forms.Dialog
{
    partial class ThemNhaTro
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
            this.txGhiChu = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            this.materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            this.swTaoPhong = new ReaLTaiizor.Controls.MaterialSwitch();
            this.comboSoPhong = new ReaLTaiizor.Controls.MaterialComboBox();
            this.btXacNhan = new ReaLTaiizor.Controls.MaterialButton();
            this.btHuy = new ReaLTaiizor.Controls.MaterialButton();
            this.txTenNhaTro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txDiaChi = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txGhiChu
            // 
            this.txGhiChu.AnimateReadOnly = false;
            this.txGhiChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txGhiChu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txGhiChu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txGhiChu.Depth = 0;
            this.txGhiChu.HideSelection = true;
            this.txGhiChu.Hint = "Ghi chú";
            this.txGhiChu.Location = new System.Drawing.Point(6, 127);
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
            this.txGhiChu.Size = new System.Drawing.Size(375, 126);
            this.txGhiChu.TabIndex = 7;
            this.txGhiChu.TabStop = false;
            this.txGhiChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txGhiChu.UseSystemPasswordChar = false;
            this.txGhiChu.TextChanged += new System.EventHandler(this.txGhiChu_TextChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.HighEmphasis = true;
            this.materialLabel3.Location = new System.Drawing.Point(6, 256);
            this.materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(357, 19);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "*Phòng sẽ được tạo tự động với ID dạng PHONG-1";
            this.materialLabel3.UseAccent = true;
            // 
            // swTaoPhong
            // 
            this.swTaoPhong.AutoSize = true;
            this.swTaoPhong.Depth = 0;
            this.swTaoPhong.Location = new System.Drawing.Point(0, 287);
            this.swTaoPhong.Margin = new System.Windows.Forms.Padding(0);
            this.swTaoPhong.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swTaoPhong.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.swTaoPhong.Name = "swTaoPhong";
            this.swTaoPhong.Ripple = true;
            this.swTaoPhong.Size = new System.Drawing.Size(154, 37);
            this.swTaoPhong.TabIndex = 9;
            this.swTaoPhong.Text = "Tự tạo phòng";
            this.swTaoPhong.UseAccentColor = false;
            this.swTaoPhong.UseVisualStyleBackColor = true;
            this.swTaoPhong.CheckedChanged += new System.EventHandler(this.swTaoPhong_CheckedChanged);
            // 
            // comboSoPhong
            // 
            this.comboSoPhong.AutoResize = false;
            this.comboSoPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboSoPhong.Depth = 0;
            this.comboSoPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboSoPhong.DropDownHeight = 174;
            this.comboSoPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSoPhong.DropDownWidth = 121;
            this.comboSoPhong.Enabled = false;
            this.comboSoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboSoPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboSoPhong.FormattingEnabled = true;
            this.comboSoPhong.Hint = "Số Lượng Phòng";
            this.comboSoPhong.IntegralHeight = false;
            this.comboSoPhong.ItemHeight = 43;
            this.comboSoPhong.Items.AddRange(new object[] {
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
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40"});
            this.comboSoPhong.Location = new System.Drawing.Point(243, 287);
            this.comboSoPhong.MaxDropDownItems = 4;
            this.comboSoPhong.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.comboSoPhong.Name = "comboSoPhong";
            this.comboSoPhong.Size = new System.Drawing.Size(120, 49);
            this.comboSoPhong.StartIndex = 0;
            this.comboSoPhong.TabIndex = 10;
            this.comboSoPhong.SelectedIndexChanged += new System.EventHandler(this.comboSoPhong_SelectedIndexChanged);
            // 
            // btXacNhan
            // 
            this.btXacNhan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btXacNhan.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btXacNhan.Depth = 0;
            this.btXacNhan.HighEmphasis = true;
            this.btXacNhan.Icon = null;
            this.btXacNhan.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btXacNhan.Location = new System.Drawing.Point(286, 362);
            this.btXacNhan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btXacNhan.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btXacNhan.Name = "btXacNhan";
            this.btXacNhan.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btXacNhan.Size = new System.Drawing.Size(95, 36);
            this.btXacNhan.TabIndex = 11;
            this.btXacNhan.Text = "Xác nhận";
            this.btXacNhan.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btXacNhan.UseAccentColor = false;
            this.btXacNhan.UseVisualStyleBackColor = true;
            this.btXacNhan.Click += new System.EventHandler(this.btXacNhan_Click);
            // 
            // btHuy
            // 
            this.btHuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btHuy.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btHuy.Depth = 0;
            this.btHuy.HighEmphasis = true;
            this.btHuy.Icon = null;
            this.btHuy.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btHuy.Location = new System.Drawing.Point(214, 362);
            this.btHuy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btHuy.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btHuy.Name = "btHuy";
            this.btHuy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btHuy.Size = new System.Drawing.Size(64, 36);
            this.btHuy.TabIndex = 12;
            this.btHuy.Text = "Huỷ";
            this.btHuy.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btHuy.UseAccentColor = true;
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
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
            this.txTenNhaTro.Hint = "Tên nhà trọ";
            this.txTenNhaTro.LeadingIcon = null;
            this.txTenNhaTro.Location = new System.Drawing.Point(6, 19);
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
            this.txTenNhaTro.Size = new System.Drawing.Size(375, 48);
            this.txTenNhaTro.TabIndex = 13;
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
            this.txDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txDiaChi.Depth = 0;
            this.txDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txDiaChi.HideSelection = true;
            this.txDiaChi.Hint = "Địa chỉ";
            this.txDiaChi.LeadingIcon = null;
            this.txDiaChi.Location = new System.Drawing.Point(6, 73);
            this.txDiaChi.MaxLength = 64;
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
            this.txDiaChi.Size = new System.Drawing.Size(375, 48);
            this.txDiaChi.TabIndex = 14;
            this.txDiaChi.TabStop = false;
            this.txDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txDiaChi.TrailingIcon = null;
            this.txDiaChi.UseSystemPasswordChar = false;
            this.txDiaChi.TextChanged += new System.EventHandler(this.txDiaChi_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btXacNhan);
            this.groupBox1.Controls.Add(this.txTenNhaTro);
            this.groupBox1.Controls.Add(this.txDiaChi);
            this.groupBox1.Controls.Add(this.btHuy);
            this.groupBox1.Controls.Add(this.comboSoPhong);
            this.groupBox1.Controls.Add(this.txGhiChu);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.swTaoPhong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 407);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Trọ";
            // 
            // ThemNhaTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 440);
            this.Controls.Add(this.groupBox1);
            this.FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            this.Name = "ThemNhaTro";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.Text = "ThemNhaTro";
            this.Load += new System.EventHandler(this.ThemNhaTro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit txGhiChu;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialSwitch swTaoPhong;
        private ReaLTaiizor.Controls.MaterialComboBox comboSoPhong;
        private ReaLTaiizor.Controls.MaterialButton btXacNhan;
        private ReaLTaiizor.Controls.MaterialButton btHuy;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txTenNhaTro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txDiaChi;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}