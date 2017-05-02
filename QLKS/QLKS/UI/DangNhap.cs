using BUS;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLKS.UI
{
    public partial class DangNhap : Form
    {
        private TaiKhoanController tk;

        public DangNhap()
        {
            InitializeComponent();
            tk = new TaiKhoanController();
        }

        public void clearTaiKhoanMatKhau()
        {
            txtTaiKhoan.Text = null;
            txtMatKhau.Text = null;
        }

        private void dangNhapHeThong(object sender, EventArgs e)
        {
            bool errTK = Regex.IsMatch(txtTaiKhoan.Text.ToString(), @"^[a-zA-Z0-9]{5,12}$", RegexOptions.IgnoreCase);
            bool errMK = Regex.IsMatch(txtMatKhau.Text.ToString(), @"^[a-zA-Z0-9]{5,12}$", RegexOptions.IgnoreCase);
            if (errTK == true && errMK == true)
            {
                errorTaiKhoan.Clear();
                errorMatKhau.Clear();
                string taikhoan = txtTaiKhoan.Text.ToString().Trim();
                string matkhau = txtMatKhau.Text.ToString().Trim();
                string cv = tk.kiemTraTaiKhoan(taikhoan, matkhau);
                if (cv != null)
                {
                    string manv = tk.layMaNhanVien(taikhoan);
                    if (cv.Equals("ad"))
                    {
                        new CauHinh(this,manv).Show();
                    }
                    if (cv.Equals("lt"))
                    {
                        new DanhSach(this, manv).Show();
                    }
                    if (cv.Equals("kt")) {
                        new ThongKe(this,manv).Show();
                    }
                    this.Hide();
                }
                else MessageBox.Show("Tài khoản không đúng hoặc chưa đăng kí...");

            }
            if (errTK == false)
                errorTaiKhoan.SetError(txtTaiKhoan, "Tài khoản hợp lệ từ 5 - 12 kí tự.");
            else errorTaiKhoan.Clear();
            if (errMK == false)
                errorMatKhau.SetError(txtMatKhau, "Mật khẩu hợp lệ từ 5 - 12 kí tự.");
            else errorMatKhau.Clear();
        }

        private void khoiPhucMatKhau(object sender, EventArgs e)
        {
            new KhoiPhuc(this).Show();
            this.Hide();
        }
    }
}
