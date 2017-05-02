using BUS;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLKS.UI
{ 
    public partial class KhoiPhuc : Form
    {
        private TaiKhoanController tk;
        private DangNhap dn;
        private string manv;

        public KhoiPhuc(DangNhap dn)
        {
            InitializeComponent();
            this.dn = dn;

            tk = new TaiKhoanController();

            lblError.Text = "";
        }

        private void khoiPhucMatKhau(object sender, EventArgs e)
        {
            // Nếu email hoặc sdt nhập chính xác sẽ bung gửi mã xác nhận tới nv
            // Show ra form nhập mã xác nhận
            //Regex pattern = new Regex(@"[a-zA-Z0-9_\.]+@[a-zA-Z]+\.[a-zA-Z]+(\.[a-zA-Z]+)*");
            //Regex pattern2 = new Regex(@"[0]+[1,9]+[0-9]+$");
            string thongtin = txtEmail.Text.Trim();
            if (Regex.IsMatch(thongtin, @"[\d]"))
            {
                if (Regex.IsMatch(thongtin, @"[\d]{10,11}"))
                {
                    lblError.Text = "";
                    manv = tk.kiemTraThongTinDangKy(thongtin);
                    //Kiểm tra database coi có nhân viên có số điện thoại đó không ?
                    if (manv != null)
                    {
                        pnlDoiMatKhau.Show();
                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại này chưa được đăng ký.");
                    }
                }
                else
                {
                    lblError.Text = "Số điện thoại không hợp lệ.";
                }
            }
            else
            {
                if (Regex.IsMatch(thongtin, @"[a-zA-Z0-9_\.]+@[a-zA-Z]+\.[a-zA-Z]+(\.[a-zA-Z]+)*"))
                {
                    lblError.Text = "";
                    manv = tk.kiemTraThongTinDangKy(thongtin);
                    //Kiểm tra database coi có nhân viên có số điện thoại đó không ?
                    if (manv != null)
                    {
                        pnlDoiMatKhau.Show();
                    }
                    else
                    {
                        MessageBox.Show("Địa chỉ email này chưa được đăng ký.");
                    }
                }
                else
                {
                    lblError.Text = "Địa chỉ email không hợp lệ.";
                }
            }
        }
        private void thoatChucNang(object sender, FormClosedEventArgs e)
        {
            dn.Show();
        }
        private void doiMatKhauMoi(object sender, EventArgs e)
        {
            string mkmoi = txtMatKhauMoi.Text;
            string mknhaplai = txtNhapLai.Text;
            if (!Regex.IsMatch(mkmoi, @"^[\\Sa-zA-Z0-9]{5,12}$", RegexOptions.IgnoreCase))
            {
                errorMatKhauMoi.SetError(txtMatKhauMoi,"Lỗi: Độ dài mật khẩu cho phép từ 5-12 kí tự\nkhông chứa khoảng trắng và kí tự đặc biệt.");
            }
            else
            {
                errorMatKhauMoi.Clear();
                if (mkmoi.Equals(mknhaplai))
                {

                    if (tk.capNhatMatKhauMoi(mkmoi, manv))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi hệ thống, vui lòng thử lại sau.", "Thông báo");
                    }
                }
                else
                {
                    errorNhapLai.SetError(txtNhapLai ,"Lỗi: mật khẩu nhập lại không khớp.");
                }
            }
        }
        private void huyKhoiPhuc(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
