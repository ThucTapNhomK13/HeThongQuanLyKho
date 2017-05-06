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
using MetroFramework;

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
                    pHIEUNHAPBindingSource.DataSource = db.PHIEUNHAPs.ToList();
                }
            else
            {
                pHIEUNHAPBindingSource.DataSource = ls;
            }
        }

        private void LoadHangXuat (List<HANGXUAT> ls = null)
        {
            if (ls == null)
                using (QuanLyKhoEntities db = new QuanLyKhoEntities())
                {
                    hANGXUATBindingSource.DataSource = db.HANGXUATs.ToList();
                }
            else
            {
                hANGXUATBindingSource.DataSource = ls;
            }
        }

        private void LoadPhieuXuat (List<PHIEUXUAT> ls = null)
        {
            if (ls == null)
                using (QuanLyKhoEntities db = new QuanLyKhoEntities())
                {
                    pHIEUXUATBindingSource.DataSource = db.PHIEUXUATs.ToList();
                }
            else
            {
                pHIEUXUATBindingSource.DataSource = ls;
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

        private void btnNhapHN_Click(object sender, EventArgs e)
        {
            using (QuanLyKhoEntities db = new QuanLyKhoEntities())
            {
                var hangnhap = hANGNHAPBindingSource.Current as HANGNHAP;

                db.HANGNHAPs.Add(hangnhap);
                db.SaveChanges();

                var hanghoa = db.HANGHOAs.Where(x => x.ma == hangnhap.maHang).SingleOrDefault();
                if (hanghoa != null)
                {
                    hanghoa.soluong += hangnhap.Slthucnhap;

                    db.HANGHOAs.Attach(hanghoa);
                    db.Entry(hanghoa).State = EntityState.Modified;
                    db.SaveChanges();
                }


                LoadHangNhap();
            }
               
        }

        private void btnHxT_Click(object sender, EventArgs e)
        {
            using (QuanLyKhoEntities db = new QuanLyKhoEntities())
            {
                var hangxuat = hANGXUATBindingSource.Current as HANGXUAT;
                var hk = db.HANGHOAs.Where(x => x.ma == hangxuat.maHang).SingleOrDefault();
                
                if (hangxuat.Slxuat <= hk.soluong)
                {
                    db.HANGXUATs.Add(hangxuat);

                    hk.soluong -= hangxuat.Slxuat;
                    db.HANGHOAs.Attach(hk);
                    db.Entry(hk).State = EntityState.Modified;

                    db.SaveChanges();

                    LoadHangXuat();
                }
                else
                {
                    MetroMessageBox.Show(this, "Số lượng xuất ra vượt quá số lượng còn trong kho", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


            }
        }

        private void btnHuyBoHN_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSuaHN_Click(object sender, EventArgs e)
        {
            txtmahhHN.Enabled = false;
        }

        private void btnHxNL_Click(object sender, EventArgs e)
        {
            txtmahhHX.Clear();
            txtmanvHX.Clear();
            txtsoluongHX.Clear();
            txtspxuatHX.Clear();

        }

        private void btnHxS_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaPN_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaHN_Click(object sender, EventArgs e)
        {
            using (QuanLyKhoEntities db = new QuanLyKhoEntities())
            {
                var xHN = hANGNHAPBindingSource.Current as HANGNHAP;
                var xhn = db.HANGNHAPs.SingleOrDefault(x => x.Spnhap == xHN.Spnhap);

                if (xhn != null)
                {
                    if (MetroMessageBox.Show(this, "Bạn chắc có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.HANGNHAPs.Attach(xhn);
                        db.HANGNHAPs.Remove(xhn);
                        db.SaveChanges();
                        LoadHangNhap();
                    }
                    
                }

                
            }
        }

        private void btnHxX_Click(object sender, EventArgs e)
        {
            using (QuanLyKhoEntities db = new QuanLyKhoEntities())
            {
                var xHX = hANGXUATBindingSource.Current as HANGXUAT;
                var xhx = db.HANGXUATs.SingleOrDefault(x => x.Spxuat == xHX.Spxuat);

                if (xhx != null)
                {
                    if (MetroMessageBox.Show(this, "Bạn chắc có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.HANGXUATs.Attach(xhx);
                        db.HANGXUATs.Remove(xhx);
                        db.SaveChanges();
                        LoadHangXuat();
                    }
                    
                }

                
            }
        }
    }
}
