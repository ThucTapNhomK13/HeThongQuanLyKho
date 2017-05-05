using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Forms;
using System.Data.Entity;
using HeThongQuanLyKho.ModelEF;

namespace HeThongQuanLyKho
{
    public partial class fHangHoa : MetroForm
    {
        public fHangHoa()
        {
            InitializeComponent();
        }

        private void LoadNhomHang ()
        {
            QLKEntities db = new QLKEntities();
            cmbNhomHang.DataSource = db.NHOMHANGs.ToList();
            cmbNhomHang.DisplayMember = "tennhom";
            cmbNhomHang.ValueMember = "ma";
        }

        private void LoadHangHoa ()
        {
            QLKEntities db = new QLKEntities();
            dgvDSHH.DataSource = db.HANGHOAs.ToList();
        }

        private void lklQuayLaij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtTenHang.Clear();
            txtBaoHang.Clear();
            txtDVT.Clear();
            txtMoTa.Clear();
            txtSoLuong.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (QLKEntities db = new QLKEntities())
            {
                var hh = hANGHOABindingSource.Current as HANGHOA;
                var HH = db.HANGHOAs.SingleOrDefault(x => x.ma == hh.ma);

                if (HH != null)
                {
                    db.HANGHOAs.Attach(HH);
                    db.HANGHOAs.Remove(HH);
                    db.SaveChanges();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (QLKEntities db = new QLKEntities())
            {
                var hh = hANGHOABindingSource.Current as HANGHOA;
                var HH = db.HANGHOAs.SingleOrDefault(x => x.ma == hh.ma);
                if (HH != null)
                {
                    HH.tenhang = hh.tenhang;
                    HH.soluong = hh.soluong;
                    HH.thoigianbaohanh = hh.thoigianbaohanh;
                    HH.mota = hh.mota;
                    HH.manhom = hh.manhom;

                    db.HANGHOAs.Attach(HH);
                    db.Entry(HH).State = EntityState.Modified;
                    db.SaveChanges();
                }
                else
                {

                    return;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (QLKEntities db = new QLKEntities())
            {
                var hh = hANGHOABindingSource.Current as HANGHOA;
                var HH = db.HANGHOAs.Where(x => x.tenhang == hh.tenhang).FirstOrDefault();
                if (HH != null)
                {
                    db.HANGHOAs.Add(hh);
                    db.SaveChanges();
                }
                else
                {

                    return;
                }
                  
            }
        }

        private void fHangHoa_Load(object sender, EventArgs e)
        {
            LoadNhomHang();
            LoadHangHoa();
        }
    }
}
