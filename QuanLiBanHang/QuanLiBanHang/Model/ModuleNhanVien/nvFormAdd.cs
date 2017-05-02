using QuanLiBanHang.Model;
using QuanLiBanHang.Model.Validation;
using System;
using System.Windows.Forms;

namespace QuanLiBanHang
{
    public partial class nvFormAdd : Form
    {
        private ModelStateDictionary ModelState;
        private INhanVienService _nvService;
        private FormMain _main;

        public nvFormAdd(INhanVienService spService):this()
        {
            _nvService = spService;
        }

        public nvFormAdd(FormMain main)
        {

            if (_nvService == null)
            {
                _nvService = new NhanVienService(new ModelStateWrapper(this.ModelState));
            }
            InitializeComponent();
            InitData();
            _main = main;
            pnlDangKy.Hide();
        }

        public nvFormAdd()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            ModelState = new ModelStateDictionary();
            _nvService = new NhanVienService(new ModelStateWrapper(this.ModelState));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public void clearText()
        {
            txtTenNV.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            dateNgaySinh.Refresh();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (_nvService.ThemNhanVien(getNhanVien()))
            {
                pnlDangKy.Show();
            }
            ViewErrors();
        }

        private NhanVien getNhanVien()
        {
            NhanVien nv = new NhanVien();
            nv.manv = _nvService.SinhMaNhanVien();
            luuMaMoiThem(nv.manv);
            nv.tennv = txtTenNV.Text.Trim();
            nv.diachi = txtDiaChi.Text;
            nv.dienthoai = txtDienThoai.Text;
            nv.ngaysinh = DateTime.Parse(dateNgaySinh.Value.ToShortDateString());

            if (radQuanLi.Checked)
            {
                nv.chucvu = 2;
            } else
            {
                nv.chucvu = 1;
            }
            
            return nv;
        }

        private void ViewErrors()
        {
            txtError.Clear();
            foreach (var entry in ModelState)
            {
                switch (entry.Key)
                {
                    case "TenNV":
                        txtError.SetError(txtTenNV, entry.Value);
                        break;
                    case "NgaySinh":
                        txtError.SetError(dateNgaySinh, entry.Value);
                        break;
                    case "DiaChi":
                        txtError.SetError(txtDiaChi, entry.Value);
                        break;
                    case "DienThoai":
                        txtError.SetError(txtDienThoai, entry.Value);
                        break;
                    case "TaiKhoan":
                        txtError.SetError(txtTaiKhoan, entry.Value);
                        break;
                    case "MatKhau":
                        txtError.SetError(txtMatKhau, entry.Value);
                        txtError.SetError(txtMatKhau2, entry.Value);
                        break;
                    default:
                        break;
                }
            }
        }

        String mamoithem = null;

        public void luuMaMoiThem(String ma)
        {
            mamoithem = ma;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text.Trim().Equals(txtMatKhau2.Text.Trim())) {

                TaiKhoan tk = new TaiKhoan();
                tk.manv = mamoithem;
                tk.taikhoan1 = txtTaiKhoan.Text.Trim();
                tk.matkhau = txtMatKhau.Text.Trim();

                if (_nvService.ThemTaiKhoan(tk))
                {
                    MessageBox.Show("Đã thêm thành công nhân viên.", "Thành công");
                    _main.dataGridView.DataSource = _nvService.DanhSachNhanVien();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp.","Thông báo lỗi");
            }
            ViewErrors();
        }
    }
}
