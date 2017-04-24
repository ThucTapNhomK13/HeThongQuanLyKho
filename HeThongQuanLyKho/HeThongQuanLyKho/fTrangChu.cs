using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyKho
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TUser_Click(object sender, EventArgs e)
        {

        }

        private void TAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            fAdmin frmAd = new fAdmin();
            frmAd.ShowDialog();
            this.Show();
        }

        private void TLogin_Click(object sender, EventArgs e)
        {

        }

        private void TLogout_Click(object sender, EventArgs e)
        {

        }

        private void TSupplier_Click(object sender, EventArgs e)
        {

        }

        private void TGroup_Click(object sender, EventArgs e)
        {

        }

        private void TImport_Click(object sender, EventArgs e)
        {

        }

        private void TExport_Click(object sender, EventArgs e)
        {

        }

        private void TGoods_Click(object sender, EventArgs e)
        {

        }
    }
}
