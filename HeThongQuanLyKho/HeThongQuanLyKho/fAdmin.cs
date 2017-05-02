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

using MetroFramework;

using System.Data.Entity;
using HeThongQuanLyKho.ModelEF;
using System.Reflection;

namespace HeThongQuanLyKho
{
    public partial class fAdmin : MetroFramework.Forms.MetroForm
    {
        public fAdmin()
        {
            InitializeComponent();
        }

        private void LoadDonVi (List<DONVI> ls=null)
        {
            if (ls != null)
                dONVIBindingSource.DataSource = ls;
            else
                using (QLKEntities db = new QLKEntities())
                {
                    dONVIBindingSource.DataSource = db.DONVIs.ToList();
                }
        }
        private void LoadNhaCungCap (List<NHACUNGCAP> ls=null)
        {
            if (ls != null)
                nHACUNGCAPBindingSource1.DataSource = ls;
            else
                using (QLKEntities db = new QLKEntities() )
                {
                    nHACUNGCAPBindingSource1.DataSource = db.NHACUNGCAPs.ToList();
                } 
        }

        private void LoadNhomHang (List<NHOMHANG> ls=null)
        {
            if (ls != null)
            {
                nHOMHANGBindingSource.DataSource = ls;
                return;
            }
            else
                using (QLKEntities db = new QLKEntities())
                {
                    nHOMHANGBindingSource.DataSource = db.NHOMHANGs.ToList();
                }
        }

        private void LoadNhanVien (List<NHANVIEN> ls =null)
        {
            if (ls != null)
            {
                nHANVIENBindingSource1.DataSource = ls;
                return;
            }
            else
                using (QLKEntities db = new QLKEntities())
                {
                    nHANVIENBindingSource1.DataSource = db.NHANVIENs.ToList();
                }
        }
        private void fAdmin_Load(object sender, EventArgs e)
        {
            LoadNhaCungCap();
            LoadDonVi();
            LoadNhomHang();
            LoadNhanVien();
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

        private bool SearchNhomHangById (int id)
        {
            using (QLKEntities db = new QLKEntities())
            {
                var nh = db.NHOMHANGs.SingleOrDefault(x => x.ma == id);
                if (nh != null)
                    return true;
            }

                return false;
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

        private void btnThemNhomHang_Click(object sender, EventArgs e)
        {
            using (QLKEntities db = new QLKEntities())
            {
                var nh = nHOMHANGBindingSource.Current as NHOMHANG;
                db.NHOMHANGs.Add(nh);
                db.SaveChanges();

                LoadNhomHang();
            }
        }

        private void btnXoaNhomHang_Click(object sender, EventArgs e)
        {
            using (QLKEntities db = new QLKEntities())
            {
                var nh = nHOMHANGBindingSource.Current as NHOMHANG;
                var NH = db.NHOMHANGs.SingleOrDefault(x => x.ma == nh.ma);
                if (NH != null)
                {
                    db.NHOMHANGs.Attach(NH);
                    db.NHOMHANGs.Remove(NH);
                    db.SaveChanges();
                    LoadNhomHang();
                    MetroMessageBox.Show(this, "Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    return;
                }
            }
        }

        private void btnSuaNhomHang_Click(object sender, EventArgs e)
        {
            using (QLKEntities db = new QLKEntities())
            {
                var nh = nHOMHANGBindingSource.Current as NHOMHANG;
                var NH = db.NHOMHANGs.SingleOrDefault(x => x.ma == nh.ma);
                if (NH != null)
                {
                    NH.tennhom = txtTenNhom.Text;
                    NH.tacdung = txtTacDung.Text;

                    db.NHOMHANGs.Attach(NH);
                    db.Entry(NH).State = EntityState.Modified;
                    db.SaveChanges();
                    LoadNhomHang();
                    MetroMessageBox.Show(this, "Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }
        }

        private void btnTKNhomHang_Click(object sender, EventArgs e)
        {
            using (QLKEntities db = new QLKEntities())
            {
                if (string.IsNullOrEmpty(txtTKNhomHang.Text) || txtTKNhomHang.Text == " ")
                {
                    LoadNhomHang();
                }
                else
                {
                    var nh = db.NHOMHANGs.Where(x => x.tennhom == txtTKNhomHang.Text || x.tacdung == txtTKNhomHang.Text).ToList();
                    LoadNhomHang(nh);
                }
                

            }
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            using (QLKEntities db = new QLKEntities())
            {
                var ncc = nHACUNGCAPBindingSource1.Current as NHACUNGCAP;
                var NCC = db.NHACUNGCAPs.SingleOrDefault(x => x.ma == ncc.ma);
                if (NCC != null)
                {
                    db.NHACUNGCAPs.Attach(NCC);
                    db.NHACUNGCAPs.Remove(NCC);
                    db.SaveChanges();
                    LoadNhaCungCap();

                }
                else
                {
                    MetroMessageBox.Show(this, "Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            using (QLKEntities db = new QLKEntities())
            {
                var ncc = nHACUNGCAPBindingSource1.Current as NHACUNGCAP;
                var NCC = db.NHACUNGCAPs.SingleOrDefault(x => x.ma == ncc.ma);
                if (NCC != null)
                {
                    NCC.tenNCC = txtTenNCC.Text;
                    NCC.sodienthoai = txtSDTNCC.Text;
                    NCC.diachi = txtDiaChiNCC.Text;

                    db.NHACUNGCAPs.Attach(NCC);
                    db.Entry(NCC).State = EntityState.Modified;
                    db.SaveChanges();
                    LoadNhaCungCap();
                }
                else
                {
                    MetroMessageBox.Show(this, "Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            using (QLKEntities db = new QLKEntities())
            {
                var ncc = nHACUNGCAPBindingSource1.Current as NHACUNGCAP;
                var NCC = db.NHACUNGCAPs.SingleOrDefault(x => x.tenNCC == ncc.tenNCC);
                if (NCC == null)
                {
                    db.NHACUNGCAPs.Add(ncc);
                    db.SaveChanges();

                    LoadNhaCungCap();
                }
                else if (string.IsNullOrEmpty(txtTenNCC.Text) && string.IsNullOrEmpty(txtTenNCC.Text))
                {
                    MessageBox.Show("Bạn chưa nhập dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (NCC != null)
                {
                    MessageBox.Show("Đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void btnTKNV_Click(object sender, EventArgs e)
        {
            using (QLKEntities db = new QLKEntities())
            {
                if (string.IsNullOrEmpty(txtTKNV.Text) || txtTKNCC.Text == " ")
                    LoadNhanVien();
                else
                {
                    var lsNCC = db.NHANVIENs.Where(x => x.hoten == txtTKNCC.Text).ToList();
                    LoadNhanVien(lsNCC);
                }

            }
        }

        private void tilXoaNV_Click(object sender, EventArgs e)
        {
            using (QLKEntities db = new QLKEntities())
            {
                var nv = nHANVIENBindingSource1.Current as NHANVIEN;
                var NV = db.NHANVIENs.SingleOrDefault(x => x.ma == nv.ma);
                if (NV != null)
                {
                    db.NHANVIENs.Attach(NV);
                    db.NHANVIENs.Remove(NV);
                    db.SaveChanges();
                    LoadNhanVien();
                }
            }
        }

        private void tilThemNV_Click(object sender, EventArgs e)
        {
            using (QLKEntities db = new QLKEntities())
            {
                using (fThemSuaNV frmThem = new fThemSuaNV())
                {
                    frmThem.ShowDialog();
                    db.NHANVIENs.Add(frmThem.NhanVienInfo);
                    db.SaveChanges();
                }
            }
            
        }

        private void tilSuaNV_Click(object sender, EventArgs e)
        {
            var nv = nHANVIENBindingSource1.Current as NHANVIEN;
            if (nv != null)
                using (QLKEntities db = new QLKEntities())
                {
                    using (fThemSuaNV frmSua = new fThemSuaNV(nv))
                    {
                        frmSua.ShowDialog();
                        NHANVIEN NV = frmSua.NhanVienInfo;
                        nv.hoten = NV.hoten;
                        nv.ngaysinh = NV.ngaysinh;
                        nv.madonvi = NV.madonvi;
                        nv.chuvu = NV.chuvu;

                        db.NHANVIENs.Attach(nv);
                        db.Entry(nv).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
            else
                MessageBox.Show("Test");
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void btnTKNCC_Click(object sender, EventArgs e)
        {
            using (QLKEntities db = new QLKEntities())
            {
                if (string.IsNullOrEmpty(txtTKNCC.Text) || txtTKNCC.Text == " ")
                    LoadNhaCungCap();
                else
                {
                    var lsNCC = db.NHACUNGCAPs.Where(x => x.tenNCC == txtTKNCC.Text || x.sodienthoai == txtTKNCC.Text || x.diachi == txtTKNCC.Text).ToList();
                    LoadNhaCungCap(lsNCC);
                }

            }
        }
    }
}
