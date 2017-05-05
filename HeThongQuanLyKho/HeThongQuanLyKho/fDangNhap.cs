using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Entity;
using HeThongQuanLyKho.ModelEF;
using MetroFramework.Forms;

namespace HeThongQuanLyKho
{
    public partial class fDangNhap : MetroForm
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Bạn chưa nhập dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDangNhap.Focus();
            }

            try
            {
                using (QLKEntities db = new QLKEntities())
                {
                    var query = from c in db.ADMINs
                                where c.tendangnhap == txtTenDangNhap.Text && c.matkhau == txtMatKhau.Text
                                select c;
                    if (query.SingleOrDefault() != null)
                    {
                        this.Hide();
                        fTrangChu frmMain = new fTrangChu(txtTenDangNhap.Text);
                        frmMain.ShowDialog();
                        frmMain.SuKien += DongForm;
                        frmMain.KichHoat();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void fDangNhap_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Focus();
        }

        private void DongForm()
        {
            this.Close();
        }
    }
}
