using BUS;
using DAO;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLKS.UI
{
    public partial class ThuePhong : Form
    {
        private DanhSach ds;
        private TinhTrang tinhTrang;
        private KhachHangController kh;
        private ThuePhongController tp;
        private PhongController p;

        public ThuePhong(DanhSach ds, string manv)
        {
            InitializeComponent();
            this.ds = ds;
            tinhTrang = new TinhTrang(txtPhong);
            this.Controls.Add(tinhTrang);

            p = new PhongController();
            kh = new KhachHangController();
            tp = new ThuePhongController();

            txtMaNV.Text = manv;
            dateNgayTra.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void themPhieuThuePhong(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text.ToString();
            string phong = txtPhong.Text.ToString();
            string dienthoai = txtDienThoai.Text.ToString();
            string hoten = txtHoTen.Text.ToString();
            string cmnd = txtCMND.Text.ToString();
            string ngaythue = DateTime.Now.ToShortDateString();
            string ngaydi = dateNgayTra.Text.ToString();
            string rgxSDT = @"^[0-9]{10,11}$";
            string rgxCMND = @"^[0-9]{9,12}$";
            string rgxTen = @"[^\d\W_]+";
            bool mSDT = Regex.IsMatch(txtDienThoai.Text.ToString().Trim(), rgxSDT, RegexOptions.IgnoreCase);
            bool mCMND = Regex.IsMatch(txtCMND.Text.ToString().Trim(), rgxCMND, RegexOptions.IgnoreCase);
            bool mTen = Regex.IsMatch(txtHoTen.Text, rgxTen, RegexOptions.IgnoreCase);

            if (dateNgayTra.Value < DateTime.Now.Date) errorNgay.SetError(dateNgayTra, "Thời gian lựa chọn không phù hợp..");
            else errorNgay.Clear();
            if (!mSDT) errorDienThoai.SetError(txtDienThoai, "Số điện thoại trống hoặc không đúng.");
            else errorDienThoai.Clear();
            if (!mCMND) errorCMND.SetError(txtCMND, "CMND trống hoặc không đúng.");
            else errorCMND.Clear();
            if (!mTen)
            {
                errorHoTen.SetError(txtHoTen, "Họ tên nhập chưa đúng.");
            }
            else errorHoTen.Clear();

            if (tinhTrang.tblTinhTrang.CurrentRow.Cells[4].Value.ToString().Contains("Đã đặt")
                        || tinhTrang.tblTinhTrang.CurrentRow.Cells[4].Value.ToString().Contains("Đang thuê"))
                MessageBox.Show("Phòng chọn không cho phép đặt phiếu mới.");

            else if (mSDT && mCMND && mTen
                && (!tinhTrang.tblTinhTrang.CurrentRow.Cells[4].Value.ToString().Contains("Đã đặt")
                || !tinhTrang.tblTinhTrang.CurrentRow.Cells[4].Value.ToString().Contains("Đang thuê"))
                && dateNgayTra.Value >= DateTime.Now.Date)
            {
                bool themKhach = kh.themKhachHang(cmnd, hoten, dienthoai);
                bool themPhieu = tp.themPhieuThue(cmnd, manv, phong, ngaythue, ngaydi);
                if (themKhach && themPhieu)
                {
                    p.doiTrangThaiPhong(phong, Option.P_DANG_THUE);
                    tinhTrang.hienThiDanhSachPhong();
                    ds.hienThiThongTin();
                    MessageBox.Show("Thuê phòng thành công");
                    ds.Enabled = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi, vui lòng kiểm tra lại...");
                }
            }

            
        }
        private void thoatThuePhong(object sender, FormClosedEventArgs e)
        {
            ds.Enabled = true;
        }
        private void kiemTraCMND(object sender, EventArgs e)
        {
            string cmnd = txtCMND.Text.Trim();
            string khach = kh.kiemTraKhachHang(cmnd);
            if (khach != null)
            {
                txtHoTen.Text = khach.Split('-')[0];
                txtDienThoai.Text = khach.Split('-')[1];
                txtHoTen.ReadOnly = true;
                txtDienThoai.ReadOnly = true;
            }
            else
            {
                txtHoTen.Text = "";
                txtDienThoai.Text = "";
                txtHoTen.ReadOnly = false;
                txtDienThoai.ReadOnly = false;
            }
        }
    }
}
