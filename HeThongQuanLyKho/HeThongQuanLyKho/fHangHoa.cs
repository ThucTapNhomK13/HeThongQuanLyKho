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
using MetroFramework;

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
            QuanLyKhoEntities db = new QuanLyKhoEntities();
            cmbNhomHang.DataSource = db.NHOMHANGs.ToList();
            cmbNhomHang.DisplayMember = "tennhom";
            cmbNhomHang.ValueMember = "ma";
        }

        private void LoadHangHoa (List<HANGHOA> ls=null)
        {
            if (ls == null)
            {
                QuanLyKhoEntities db = new QuanLyKhoEntities();
                hANGHOABindingSource1.DataSource = db.HANGHOAs.ToList();
            }
            else
                hANGHOABindingSource1.DataSource = ls;
            
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
            using (QuanLyKhoEntities db = new QuanLyKhoEntities())
            {
                var hh = hANGHOABindingSource1.Current as HANGHOA;
                var HH = db.HANGHOAs.SingleOrDefault(x => x.ma == hh.ma);

                if (HH != null)
                {
                    db.HANGHOAs.Attach(HH);
                    db.HANGHOAs.Remove(HH);
                    db.SaveChanges();

                    LoadHangHoa();
                }
                else
                {
                    MetroMessageBox.Show(this, "Lỗi");
                    return;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (QuanLyKhoEntities db = new QuanLyKhoEntities())
            {
                var hh = hANGHOABindingSource1.Current as HANGHOA;
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
                LoadHangHoa();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (QuanLyKhoEntities db = new QuanLyKhoEntities())
            {
                HANGHOA hh = hANGHOABindingSource1.Current as HANGHOA;
                var HH = db.HANGHOAs.SingleOrDefault(x => x.tenhang == hh.tenhang);
                if (HH == null)
                {
                    db.HANGHOAs.Add(hh);
                    db.SaveChanges();

                    
                }
                else
                {
                    MetroMessageBox.Show(this, "Sản phẩm đã tồn tại, bạn phải nhập sản phẩm khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenHang.Focus();
                    return;
                }

                LoadHangHoa();


            }
        }

        private void fHangHoa_Load(object sender, EventArgs e)
        {
            LoadNhomHang();
            LoadHangHoa();
        }



        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            using (QuanLyKhoEntities db = new QuanLyKhoEntities())
            {
                if (string.IsNullOrEmpty(txtTimKiem.Text) || txtTimKiem.Text == " ")
                {
                    LoadHangHoa();
                }
                else
                {
                    var ls = db.HANGHOAs.Where(x => x.tenhang.Contains(txtTimKiem.Text) || x.donvitinh.Contains(txtTimKiem.Text)).ToList();
                    LoadHangHoa(ls);
                }
            }
        }
    }
}
