using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Entity;
using HeThongQuanLyKho.ModelEF;

namespace HeThongQuanLyKho
{
    public partial class fAdmin : MetroFramework.Forms.MetroForm
    {
        public fAdmin()
        {
            InitializeComponent();
        }

        private void LoadDonVi ()
        {
            using (QLKEntities db = new QLKEntities())
            {
                dONVIBindingSource.DataSource = db.DONVIs.ToList();
            }
        }
        private void LoadNhaCungCap ()
        {
            using (QLKEntities db = new QLKEntities() )
            {
                nHACUNGCAPBindingSource1.DataSource = db.NHACUNGCAPs.ToList();
            } 
        }

        private void LoadNhomHang ()
        {
            using (QLKEntities db = new QLKEntities())
            {
                nHOMHANGBindingSource.DataSource = db.NHOMHANGs.ToList();
            }
        }
        private void fAdmin_Load(object sender, EventArgs e)
        {
            LoadNhaCungCap();
            LoadDonVi();
            LoadNhomHang();
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            using (QLKEntities db = new QLKEntities())
            {
                DONVI dv = dONVIBindingSource.Current as DONVI;
                db.DONVIs.Add(dv);
                db.SaveChanges();
                
                LoadDonVi();
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            txtDiaChiNCC.Clear();
            txtSDTNCC.Clear();
            txtTenNCC.Clear();
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            txtTenNhom.Clear();
            txtTacDung.Clear();
        }
    }
}
