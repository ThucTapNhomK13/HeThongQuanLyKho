using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HeThongQuanLyKho.ModelEF;

namespace HeThongQuanLyKho
{
    public partial class fNhapXuat : MetroFramework.Forms.MetroForm
    {
        private void LoadNhaCungCap()
        {
            using (QuanLyKhoEntities db = new QuanLyKhoEntities())
            {
                cmbNCCNhap.DataSource = db.NHACUNGCAPs.ToList();
                cmbNCCNhap.DisplayMember = "tenNCC";
                cmbNCCNhap.ValueMember = "ma";
            }
        }

        private void LoadHangNhap(List<HANGNHAP> ls = null)
        {
            if (ls == null)
                using (QuanLyKhoEntities db = new QuanLyKhoEntities())
                {
                    hANGNHAPBindingSource.DataSource = db.HANGNHAPs.ToList();
                }
            else
            {
                hANGNHAPBindingSource.DataSource = ls;
            }
                
        }

        private void LoadPhieuNhap(List<PHIEUNHAP> ls = null)
        {
            if (ls == null)
                using (QuanLyKhoEntities db = new QuanLyKhoEntities())
                {
                }
            else
            {

            }
        }

        private void LoadHangXuat (List<HANGXUAT> ls = null)
        {
            if (ls == null)
                using (QuanLyKhoEntities db = new QuanLyKhoEntities())
                {
                }
            else
            {

            }
        }

        private void LoadPhieuXuat (List<PHIEUXUAT> ls = null)
        {
            if (ls == null)
                using (QuanLyKhoEntities db = new QuanLyKhoEntities())
                {
                }
            else
            {

            }
        }


        public fNhapXuat()
        {
            InitializeComponent();
        }

        private void fNhapXuat_Load(object sender, EventArgs e)
        {
            LoadHangNhap();
            LoadHangXuat();
            LoadPhieuNhap();
            LoadHangXuat();
        }

        
    }
}
