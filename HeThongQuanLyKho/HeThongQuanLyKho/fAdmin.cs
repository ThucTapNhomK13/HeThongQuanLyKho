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
                var DVd = db.DONVIs.Where(x => x.tendonvi == dv.tendonvi).FirstOrDefault<DONVI>();

                if (DVd == null)
                {
                    db.DONVIs.Add(dv);
                    db.SaveChanges();

                    LoadDonVi();
                }
                else if (string.IsNullOrEmpty(txtChucNangDonVi.Text) && string.IsNullOrEmpty(txtTenDonVi.Text))
                {
                    MessageBox.Show("Bạn chưa nhập dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MessageBox.Show("Đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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

        private void btnNhapLaiDV_Click(object sender, EventArgs e)
        {
            txtTenDonVi.Clear();
            txtChucNangDonVi.Clear();
        }

        private void btnXoaDonVi_Click(object sender, EventArgs e)
        {
            using (QLKEntities db = new QLKEntities())
            {
                DONVI dv = dONVIBindingSource.Current as DONVI;
                var DVd = db.DONVIs.Where(x => x.ma == dv.ma).SingleOrDefault();
                if (DVd != null)
                {
                    db.DONVIs.Attach(DVd);
                    db.DONVIs.Remove(DVd);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDonVi();
                }
                else
                {
                    MessageBox.Show("Không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void btnSuaDonVi_Click(object sender, EventArgs e)
        {
            using (QLKEntities db = new QLKEntities())
            {
                var dv = dONVIBindingSource.Current as DONVI;
                var Dvd = db.DONVIs.SingleOrDefault(x => x.ma == dv.ma);

                if (Dvd != null)
                {
                    Dvd.tendonvi = dv.tendonvi;
                    Dvd.chucnang = dv.chucnang;

                    db.DONVIs.Attach(Dvd);
                    db.Entry(Dvd).State = EntityState.Modified;
                    db.SaveChanges();
                    LoadDonVi();
                }
                
                
            }
        }
    }
}
