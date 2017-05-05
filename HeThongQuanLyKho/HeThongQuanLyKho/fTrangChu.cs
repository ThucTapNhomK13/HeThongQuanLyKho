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
    public partial class fTrangChu : MetroFramework.Forms.MetroForm
    {
        public delegate void ClickHandle();
        public event ClickHandle SuKien;

        public void KichHoat()
        {
            if (SuKien != null)
                SuKien();
        }

        public fTrangChu(string text)
        {
            InitializeComponent();
            lblTenDangNhap.Text = text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            fAdmin frmAd = new fAdmin();
            frmAd.ShowDialog();
            this.Show();
        }
        
        private void TExport_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (fHangHoa frmHH = new fHangHoa())
            {
                frmHH.ShowDialog();
            }
            this.Show();
        }

        private void TGoods_Click(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void THelp_Click(object sender, EventArgs e)
        {

        }
    }
}
