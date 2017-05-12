namespace HeThongQuanLyKho
{
    partial class fThemSuaNV
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
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtHoTen = new MetroFramework.Controls.MetroTextBox();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtpNgaySinh = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cmbDonVi = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnLuu = new MetroFramework.Controls.MetroButton();
            this.ckbGioiTinh = new MetroFramework.Controls.MetroCheckBox();
            this.tggChucVu = new MetroFramework.Controls.MetroToggle();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(45, 114);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Họ và tên";
            // 
            // txtHoTen
            // 
            // 
            // 
            // 
            this.txtHoTen.CustomButton.Image = null;
            this.txtHoTen.CustomButton.Location = new System.Drawing.Point(202, 2);
            this.txtHoTen.CustomButton.Name = "";
            this.txtHoTen.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtHoTen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHoTen.CustomButton.TabIndex = 1;
            this.txtHoTen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHoTen.CustomButton.UseSelectable = true;
            this.txtHoTen.CustomButton.Visible = false;
            this.txtHoTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "hoten", true));
            this.txtHoTen.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtHoTen.Lines = new string[0];
            this.txtHoTen.Location = new System.Drawing.Point(128, 110);
            this.txtHoTen.MaxLength = 32767;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PasswordChar = '\0';
            this.txtHoTen.PromptText = "Họ và tên";
            this.txtHoTen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.SelectionLength = 0;
            this.txtHoTen.SelectionStart = 0;
            this.txtHoTen.ShortcutsEnabled = true;
            this.txtHoTen.Size = new System.Drawing.Size(230, 30);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.UseCustomBackColor = true;
            this.txtHoTen.UseCustomForeColor = true;
            this.txtHoTen.UseSelectable = true;
            this.txtHoTen.WaterMark = "Họ và tên";
            this.txtHoTen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHoTen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(45, 146);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Ngày sinh";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "MM/dd/yyyy";
            this.dtpNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nHANVIENBindingSource, "ngaysinh", true));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(128, 148);
            this.dtpNgaySinh.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(230, 29);
            this.dtpNgaySinh.TabIndex = 3;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(45, 178);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(57, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Giới tính";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(45, 210);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(56, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Chức vụ";
            // 
            // cmbDonVi
            // 
            this.cmbDonVi.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nHANVIENBindingSource, "madonvi", true));
            this.cmbDonVi.FormattingEnabled = true;
            this.cmbDonVi.ItemHeight = 23;
            this.cmbDonVi.Location = new System.Drawing.Point(128, 233);
            this.cmbDonVi.Name = "cmbDonVi";
            this.cmbDonVi.Size = new System.Drawing.Size(230, 29);
            this.cmbDonVi.TabIndex = 8;
            this.cmbDonVi.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(45, 242);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(46, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Đơn vị";
            // 
            // btnLuu
            // 
            this.btnLuu.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLuu.Location = new System.Drawing.Point(267, 284);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(91, 32);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseSelectable = true;
            // 
            // ckbGioiTinh
            // 
            this.ckbGioiTinh.AutoSize = true;
            this.ckbGioiTinh.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.nHANVIENBindingSource, "gioitinh", true));
            this.ckbGioiTinh.Location = new System.Drawing.Point(128, 185);
            this.ckbGioiTinh.Name = "ckbGioiTinh";
            this.ckbGioiTinh.Size = new System.Drawing.Size(39, 15);
            this.ckbGioiTinh.TabIndex = 11;
            this.ckbGioiTinh.Text = "Nữ";
            this.ckbGioiTinh.UseSelectable = true;
            this.ckbGioiTinh.CheckStateChanged += new System.EventHandler(this.ckbGioiTinh_CheckStateChanged);
            // 
            // tggChucVu
            // 
            this.tggChucVu.AutoSize = true;
            this.tggChucVu.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.nHANVIENBindingSource, "chuvu", true));
            this.tggChucVu.Location = new System.Drawing.Point(128, 208);
            this.tggChucVu.Name = "tggChucVu";
            this.tggChucVu.Size = new System.Drawing.Size(80, 17);
            this.tggChucVu.TabIndex = 12;
            this.tggChucVu.Text = "Off";
            this.tggChucVu.UseSelectable = true;
            // 
            // fThemSuaNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 340);
            this.Controls.Add(this.tggChucVu);
            this.Controls.Add(this.ckbGioiTinh);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cmbDonVi);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.metroLabel1);
            this.Name = "fThemSuaNV";
            this.Text = "Thêm / Sửa Nhân Viên";
            this.Load += new System.EventHandler(this.fThemSuaNV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtHoTen;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime dtpNgaySinh;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cmbDonVi;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btnLuu;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private MetroFramework.Controls.MetroCheckBox ckbGioiTinh;
        private MetroFramework.Controls.MetroToggle tggChucVu;
    }
}