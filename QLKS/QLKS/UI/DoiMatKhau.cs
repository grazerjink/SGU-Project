using BUS;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLKS.UI
{
    public partial class DoiMatKhau : Form
    {
        private DanhSach ds;
        private ThongKe tke;
        private CauHinh ch;
        private string manv;
        private TaiKhoanController tk = new TaiKhoanController();

        public DoiMatKhau(CauHinh ch, string manv)
        {
            InitializeComponent();
            this.ch = ch;
            this.manv = manv;
        }
        public DoiMatKhau(ThongKe tke, string manv)
        {
            InitializeComponent();
            this.tke = tke;
            this.manv = manv;
        }
        public DoiMatKhau(DanhSach ds, string manv)
        {
            InitializeComponent();
            this.ds = ds;
            this.manv = manv;
        }

        private void doiMatKhau(object sender, System.EventArgs e)
        {
            string mkcu = txtMatKhauHienTai.Text;
            string mkmoi = txtMatKhauMoi.Text;
            string mknhaplai = txtNhapLai.Text;
            if (!tk.kiemTraMatKhauCu(mkcu, manv))
            {
                lblLoi.Text = "Lỗi: Mật khẩu hiện tại không chính xác.";
            }
            else
            {
                if (!Regex.IsMatch(mkmoi, @"^[\\Sa-zA-Z0-9]{5,12}$", RegexOptions.IgnoreCase))
                {
                    lblLoi.Text = "Lỗi: Độ dài mật khẩu cho phép từ 5-12 kí tự\nkhông chứa khoảng trắng và kí tự đặc biệt.";
                }
                else
                {
                    if (mkmoi.Equals(mknhaplai))
                    {
                        lblLoi.Text = null;
                        if (tk.capNhatMatKhauMoi(mkmoi, manv))
                        {
                            MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                            txtMatKhauHienTai.Text = null;
                            txtMatKhauMoi.Text = null;
                            txtNhapLai.Text = null;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi hệ thống, vui lòng thử lại sau.", "Thông báo");
                        }
                    }
                    else
                    {
                        lblLoi.Text = "Lỗi: mật khẩu nhập lại không khớp.";
                    }
                }
            }
        }        
        private void huy(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void thoat(object sender, FormClosedEventArgs e)
        {
            if (ds != null)
                ds.Enabled = true;
            if (tke != null)
                tke.Enabled = true;
            if (ch != null)
                ch.Enabled = true;

        }
    }
}
