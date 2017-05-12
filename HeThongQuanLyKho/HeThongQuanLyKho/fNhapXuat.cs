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
        private void LoadSpNhap ()
        {
            
        }
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
            LoadNhaCungCap();
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
            using (QuanLyKhoEntities db = new QuanLyKhoEntities())
            {
                var hn = hANGNHAPBindingSource.Current as HANGNHAP;
                var HN = db.HANGNHAPs.SingleOrDefault(x => x.Spnhap == hn.Spnhap);

                if (HN != null)
                {
                    HN.maHang = hn.maHang;
                    HN.Slchungtu = hn.Slchungtu;
                    HN.Slthucnhap = hn.Slthucnhap;
                    HN.Sphieubaohang = hn.Sphieubaohang;

                    db.HANGNHAPs.Attach(HN);
                    db.Entry(HN).State = EntityState.Modified;
                    db.SaveChanges();

                    LoadHangNhap();
                }
            }
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
            using (QuanLyKhoEntities db = new QuanLyKhoEntities())
            {
                var xh = hANGXUATBindingSource.Current as HANGXUAT;
                var XH = db.HANGXUATs.SingleOrDefault(x => x.Spxuat == xh.Spxuat);
                if (XH != null)
                {
                    XH.maHang = xh.maHang;
                    XH.maNV = xh.maNV;
                    XH.Slxuat = xh.Slxuat;

                    db.HANGXUATs.Attach(XH);
                    db.Entry(XH).State = EntityState.Modified;
                    db.SaveChanges();

                    LoadHangXuat();
                }
            }
        }

        private void btnSuaPN_Click(object sender, EventArgs e)
        {
            using (QuanLyKhoEntities db = new QuanLyKhoEntities())
            {
                var xPN = pHIEUNHAPBindingSource.Current as PHIEUNHAP;
                var xpn = db.PHIEUNHAPs.FirstOrDefault(x => x.Spnhap == xPN.Spnhap);
                if (xpn != null)
                {
                    xpn.lydonhap = xPN.lydonhap;
                    xpn.maNCC = xPN.maNCC;
                    xpn.maNV = xPN.maNV;
                    xpn.ngaynhap = xPN.ngaynhap;

                    db.PHIEUNHAPs.Attach(xpn);
                    db.Entry(xpn).State = EntityState.Modified;
                    db.SaveChanges();
                }
                else
                {

                    return;
                }
                LoadPhieuNhap();
            }
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

        private void btnTkHX_Click(object sender, EventArgs e)
        {
            using (QuanLyKhoEntities db = new QuanLyKhoEntities())
            {
                if (txtTkHX.Text == " " || string.IsNullOrEmpty(txtTkHX.Text))
                {
                    LoadHangXuat();
                }
                else
                {
                    var tkXH = db.HANGXUATs.Where(x => x.Spxuat == txtTkHX.Text).ToList();
                    LoadHangXuat(tkXH);
                }
            }
            
        }

        private void btnTkHN_Click(object sender, EventArgs e)
        {
            using (QuanLyKhoEntities db = new QuanLyKhoEntities())
            {
                if (txtTkHN.Text == " " || string.IsNullOrEmpty(txtTkHN.Text))
                {
                    LoadHangNhap();
                }
                else
                {
                    var tkHN = db.HANGNHAPs.Where(x => x.Spnhap == txtTkHN.Text).ToList();
                    LoadHangNhap(tkHN);
                }
            }
        }

        private void btnNhapPN_Click(object sender, EventArgs e)
        {
            using (QuanLyKhoEntities db = new QuanLyKhoEntities())
            {
                var pn = pHIEUNHAPBindingSource.Current as PHIEUNHAP;
                if (db.PHIEUNHAPs.SingleOrDefault(x=> x.Spnhap == pn.Spnhap) == null)
                {
                    db.PHIEUNHAPs.Add(pn);
                    db.SaveChanges();   
                }
                else
                {
                    MetroMessageBox.Show(this, "Sản phẩm đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                LoadPhieuNhap();
            }
        }

        private void btnXoaPN_Click(object sender, EventArgs e)
        {
            using (QuanLyKhoEntities db = new QuanLyKhoEntities())
            {
                var pn = pHIEUNHAPBindingSource.Current as PHIEUNHAP;
                var PN = db.PHIEUNHAPs.SingleOrDefault(x => x.Spnhap == pn.Spnhap);
                if (PN != null)
                {
                    db.PHIEUNHAPs.Remove(PN);
                    db.SaveChanges();
                }
                else
                {
                    return;
                }
                LoadPhieuNhap();
            }
        }

        private void btnTkPN_Click(object sender, EventArgs e)
        {
            using (QuanLyKhoEntities db = new QuanLyKhoEntities())
            {
                if (txtTkPN.Text == " " || string.IsNullOrEmpty(txtTkPN.Text))
                {
                    LoadPhieuNhap();
                }
                else
                {
                    var lsPN = db.PHIEUNHAPs.Where(x => x.Spnhap == txtTkPN.Text).ToList();
                    LoadPhieuNhap(lsPN);
                }
            }
        }

        private void btnTkPX_Click(object sender, EventArgs e)
        {
            using (QuanLyKhoEntities db = new QuanLyKhoEntities())
            {
                if (txtTkPX.Text == " " || string.IsNullOrEmpty(txtTkPX.Text))
                {
                    LoadPhieuXuat();
                }
                else
                {
                    var lsPX = db.PHIEUXUATs.Where(x => x.Spxuat == txtTkPX.Text).ToList();
                    LoadPhieuXuat(lsPX);
                }
            }
        }

        private void btnPxT_Click(object sender, EventArgs e)
        {
            using (QuanLyKhoEntities db = new QuanLyKhoEntities())
            {
                var px = pHIEUXUATBindingSource.Current as PHIEUXUAT;
                if (db.PHIEUXUATs.SingleOrDefault(x => x.Spxuat == px.Spxuat) == null)
                {
                    db.PHIEUXUATs.Add(px);
                    db.SaveChanges();
                }
                else
                {
                    MetroMessageBox.Show(this, "Sản phẩm đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                LoadPhieuXuat();
            }
        }

        private void btnPXx_Click(object sender, EventArgs e)
        {
            using (QuanLyKhoEntities db = new QuanLyKhoEntities())
            {
                var px = pHIEUXUATBindingSource.Current as PHIEUXUAT;
                var PX = db.PHIEUXUATs.SingleOrDefault(x => x.Spxuat == px.Spxuat);
                if (PX != null)
                {
                    db.PHIEUXUATs.Remove(PX);
                    db.SaveChanges();
                }
                else
                {
                    return;
                }
                LoadPhieuXuat();
            }
        }

        private void btnPxHB_Click(object sender, EventArgs e)
        {
            txtPXLyDo.Clear();
            txtPXSP.Clear();
            txtPXNV.Clear();
        }

        private void btnHuyBoPN_Click(object sender, EventArgs e)
        {
            txtPNSP.Clear();
            txtPNNV.Clear();
            txtPNLyDo.Clear();
        }

        private void btnPxS_Click(object sender, EventArgs e)
        {
            using (QuanLyKhoEntities db = new QuanLyKhoEntities())
            {
                var px = pHIEUXUATBindingSource.Current as PHIEUXUAT;
                var PX = db.PHIEUXUATs.FirstOrDefault(x => x.Spxuat == px.Spxuat);

                if (PX != null)
                {
                    PX.lydoxuat = px.lydoxuat;
                    PX.maNV = px.maNV;
                    PX.ngayxuat = px.ngayxuat;

                    db.PHIEUXUATs.Attach(PX);
                    db.Entry(PX).State = EntityState.Modified;
                    db.SaveChanges();
                }
                else
                {
                    return;
                }
                LoadPhieuXuat();
            }
        }
    }
}
