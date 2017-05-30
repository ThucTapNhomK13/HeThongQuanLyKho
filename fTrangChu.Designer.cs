namespace HeThongQuanLyKho
{
    partial class fTrangChu
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
            this.TGoods = new MetroFramework.Controls.MetroTile();
            this.TAdmin = new MetroFramework.Controls.MetroTile();
            this.TExport = new MetroFramework.Controls.MetroTile();
            this.THelp = new MetroFramework.Controls.MetroTile();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.lblTenDangNhap = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // TGoods
            // 
            this.TGoods.ActiveControl = null;
            this.TGoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.TGoods.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TGoods.Location = new System.Drawing.Point(269, 209);
            this.TGoods.Name = "TGoods";
            this.TGoods.Size = new System.Drawing.Size(276, 95);
            this.TGoods.TabIndex = 4;
            this.TGoods.Text = "Hàng hóa";
            this.TGoods.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TGoods.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TGoods.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TGoods.UseCustomBackColor = true;
            this.TGoods.UseCustomForeColor = true;
            this.TGoods.UseSelectable = true;
            this.TGoods.Click += new System.EventHandler(this.TGoods_Click);
            // 
            // TAdmin
            // 
            this.TAdmin.ActiveControl = null;
            this.TAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.TAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TAdmin.Location = new System.Drawing.Point(551, 105);
            this.TAdmin.Name = "TAdmin";
            this.TAdmin.Size = new System.Drawing.Size(276, 407);
            this.TAdmin.TabIndex = 6;
            this.TAdmin.Text = "Quản trị";
            this.TAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TAdmin.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TAdmin.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TAdmin.UseCustomBackColor = true;
            this.TAdmin.UseCustomForeColor = true;
            this.TAdmin.UseSelectable = true;
            this.TAdmin.Click += new System.EventHandler(this.TAdmin_Click);
            // 
            // TExport
            // 
            this.TExport.ActiveControl = null;
            this.TExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.TExport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TExport.Location = new System.Drawing.Point(269, 105);
            this.TExport.Name = "TExport";
            this.TExport.Size = new System.Drawing.Size(276, 95);
            this.TExport.TabIndex = 9;
            this.TExport.Text = "Nhập / Xuất";
            this.TExport.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TExport.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TExport.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TExport.UseCustomBackColor = true;
            this.TExport.UseCustomForeColor = true;
            this.TExport.UseSelectable = true;
            this.TExport.Click += new System.EventHandler(this.TExport_Click);
            // 
            // THelp
            // 
            this.THelp.ActiveControl = null;
            this.THelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.THelp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.THelp.Location = new System.Drawing.Point(269, 313);
            this.THelp.Name = "THelp";
            this.THelp.Size = new System.Drawing.Size(276, 199);
            this.THelp.TabIndex = 10;
            this.THelp.Text = "Trợ giúp";
            this.THelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.THelp.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.THelp.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.THelp.UseCustomBackColor = true;
            this.THelp.UseCustomForeColor = true;
            this.THelp.UseSelectable = true;
            this.THelp.Click += new System.EventHandler(this.THelp_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroLink1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLink1.Image = global::HeThongQuanLyKho.Properties.Resources.icon_402_128;
            this.metroLink1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink1.ImageSize = 40;
            this.metroLink1.Location = new System.Drawing.Point(23, 26);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(133, 45);
            this.metroLink1.TabIndex = 11;
            this.metroLink1.Text = "Đăng xuất";
            this.metroLink1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTenDangNhap.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTenDangNhap.Location = new System.Drawing.Point(940, 52);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(0, 0);
            this.lblTenDangNhap.TabIndex = 12;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(839, 52);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 25);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Tài khoản: ";
            // 
            // fTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 572);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.THelp);
            this.Controls.Add(this.TExport);
            this.Controls.Add(this.TAdmin);
            this.Controls.Add(this.TGoods);
            this.Name = "fTrangChu";
            this.Text = "Hệ thống quản lý kho";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile TGoods;
        private MetroFramework.Controls.MetroTile TAdmin;
        private MetroFramework.Controls.MetroTile TExport;
        private MetroFramework.Controls.MetroTile THelp;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLabel lblTenDangNhap;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

