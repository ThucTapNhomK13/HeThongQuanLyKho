namespace HeThongQuanLyKho
{
    partial class frmMain
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
            this.TUser = new MetroFramework.Controls.MetroTile();
            this.TLogin = new MetroFramework.Controls.MetroTile();
            this.TLogout = new MetroFramework.Controls.MetroTile();
            this.TGoods = new MetroFramework.Controls.MetroTile();
            this.TAdmin = new MetroFramework.Controls.MetroTile();
            this.TGroup = new MetroFramework.Controls.MetroTile();
            this.TImport = new MetroFramework.Controls.MetroTile();
            this.TExport = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // TUser
            // 
            this.TUser.ActiveControl = null;
            this.TUser.Location = new System.Drawing.Point(159, 109);
            this.TUser.Name = "TUser";
            this.TUser.Size = new System.Drawing.Size(276, 95);
            this.TUser.TabIndex = 0;
            this.TUser.Text = "Thông tin tài khoản";
            this.TUser.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TUser.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TUser.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TUser.UseSelectable = true;
            this.TUser.Click += new System.EventHandler(this.TUser_Click);
            // 
            // TLogin
            // 
            this.TLogin.ActiveControl = null;
            this.TLogin.Location = new System.Drawing.Point(159, 210);
            this.TLogin.Name = "TLogin";
            this.TLogin.Size = new System.Drawing.Size(135, 95);
            this.TLogin.TabIndex = 1;
            this.TLogin.Text = "Đăng nhập";
            this.TLogin.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TLogin.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TLogin.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TLogin.UseSelectable = true;
            this.TLogin.Click += new System.EventHandler(this.TLogin_Click);
            // 
            // TLogout
            // 
            this.TLogout.ActiveControl = null;
            this.TLogout.Location = new System.Drawing.Point(300, 210);
            this.TLogout.Name = "TLogout";
            this.TLogout.Size = new System.Drawing.Size(135, 95);
            this.TLogout.TabIndex = 2;
            this.TLogout.Text = "Đăng xuất";
            this.TLogout.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TLogout.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TLogout.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TLogout.UseSelectable = true;
            this.TLogout.Click += new System.EventHandler(this.TLogout_Click);
            // 
            // TGoods
            // 
            this.TGoods.ActiveControl = null;
            this.TGoods.Location = new System.Drawing.Point(159, 335);
            this.TGoods.Name = "TGoods";
            this.TGoods.Size = new System.Drawing.Size(276, 196);
            this.TGoods.TabIndex = 4;
            this.TGoods.Text = "Hàng hóa";
            this.TGoods.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TGoods.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TGoods.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TGoods.UseSelectable = true;
            this.TGoods.Click += new System.EventHandler(this.TGoods_Click);
            // 
            // TAdmin
            // 
            this.TAdmin.ActiveControl = null;
            this.TAdmin.Location = new System.Drawing.Point(592, 109);
            this.TAdmin.Name = "TAdmin";
            this.TAdmin.Size = new System.Drawing.Size(276, 196);
            this.TAdmin.TabIndex = 6;
            this.TAdmin.Text = "Quản trị";
            this.TAdmin.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TAdmin.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TAdmin.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TAdmin.UseSelectable = true;
            this.TAdmin.Click += new System.EventHandler(this.TAdmin_Click);
            // 
            // TGroup
            // 
            this.TGroup.ActiveControl = null;
            this.TGroup.Location = new System.Drawing.Point(592, 335);
            this.TGroup.Name = "TGroup";
            this.TGroup.Size = new System.Drawing.Size(135, 196);
            this.TGroup.TabIndex = 7;
            this.TGroup.Text = "Nhóm hàng";
            this.TGroup.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TGroup.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TGroup.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TGroup.UseSelectable = true;
            this.TGroup.Click += new System.EventHandler(this.TGroup_Click);
            // 
            // TImport
            // 
            this.TImport.ActiveControl = null;
            this.TImport.Location = new System.Drawing.Point(733, 335);
            this.TImport.Name = "TImport";
            this.TImport.Size = new System.Drawing.Size(135, 95);
            this.TImport.TabIndex = 8;
            this.TImport.Text = "Nhập kho";
            this.TImport.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TImport.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TImport.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TImport.UseSelectable = true;
            this.TImport.Click += new System.EventHandler(this.TImport_Click);
            // 
            // TExport
            // 
            this.TExport.ActiveControl = null;
            this.TExport.Location = new System.Drawing.Point(733, 436);
            this.TExport.Name = "TExport";
            this.TExport.Size = new System.Drawing.Size(135, 95);
            this.TExport.TabIndex = 9;
            this.TExport.Text = "Xuất kho";
            this.TExport.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TExport.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TExport.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TExport.UseSelectable = true;
            this.TExport.Click += new System.EventHandler(this.TExport_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 572);
            this.Controls.Add(this.TExport);
            this.Controls.Add(this.TImport);
            this.Controls.Add(this.TGroup);
            this.Controls.Add(this.TAdmin);
            this.Controls.Add(this.TGoods);
            this.Controls.Add(this.TLogout);
            this.Controls.Add(this.TLogin);
            this.Controls.Add(this.TUser);
            this.Name = "frmMain";
            this.Text = "Hệ thống quản lý kho";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile TUser;
        private MetroFramework.Controls.MetroTile TLogin;
        private MetroFramework.Controls.MetroTile TLogout;
        private MetroFramework.Controls.MetroTile TGoods;
        private MetroFramework.Controls.MetroTile TAdmin;
        private MetroFramework.Controls.MetroTile TGroup;
        private MetroFramework.Controls.MetroTile TImport;
        private MetroFramework.Controls.MetroTile TExport;
    }
}

