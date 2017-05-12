using System;
using System.Linq;
using System.Windows.Forms;
using HeThongQuanLyKho.ModelEF;

namespace HeThongQuanLyKho
{
    public partial class fThemSuaNV : MetroFramework.Forms.MetroForm
    {
        public NHANVIEN NhanVienInfo
        {
            get
            {
                NHANVIEN nv = new NHANVIEN();
                nv.hoten = txtHoTen.Text;
                nv.ngaysinh = dtpNgaySinh.Value;
                nv.gioitinh = ckbGioiTinh.Text;
                if (tggChucVu.Checked)
                    nv.chuvu = "1";
                else
                    nv.chuvu = "0";
                nv.madonvi = (cmbDonVi.SelectedItem as DONVI).ma;
                return nv;
            }
        }

        public fThemSuaNV()
        {
            InitializeComponent();
        }

        public fThemSuaNV(NHANVIEN nv = null)
        {
            InitializeComponent();

            txtHoTen.Text = nv.hoten;
            if (nv.ngaysinh != null)
                dtpNgaySinh.Value = DateTime.Parse(nv.ngaysinh.ToString());

            if (nv.gioitinh == "Nam")
            {
                ckbGioiTinh.Text = "Nam";
                ckbGioiTinh.Checked = true;
            }
            else if (nv.gioitinh == "Nữ")
            {
                ckbGioiTinh.Text = "Nữ";
                ckbGioiTinh.Checked = false;
            }

            if (nv.chuvu == "1")
                tggChucVu.Checked = true;
            else
                tggChucVu.Checked = false;


        }

        private void LoadDonVi()
        {
            cmbDonVi.DisplayMember = "chucnang";
            cmbDonVi.ValueMember = "ma";

            QuanLyKhoEntities db = new QuanLyKhoEntities();
            cmbDonVi.DataSource = db.DONVIs.ToList();
        }

        private void fThemSuaNV_Load(object sender, EventArgs e)
        {
            LoadDonVi();
        }

        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckbGioiTinh_CheckStateChanged(object sender, EventArgs e)
        {
            if (ckbGioiTinh.CheckState == CheckState.Checked)
                ckbGioiTinh.Text = "Nam";
            else if (ckbGioiTinh.CheckState == CheckState.Unchecked)
                ckbGioiTinh.Text = "Nữ";
            
        }

        
    }
}
