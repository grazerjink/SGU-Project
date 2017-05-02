using BUS;
using DAO;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLKS.UI
{
    public partial class DatPhong : Form
    {
        private DanhSach ds;
        private TinhTrang tinhTrang;
        private KhachHangController kh;
        private PhongController p;
        private DatPhongController dp;

        public DatPhong(DanhSach ds, string manv)
        {
            InitializeComponent();
            this.ds = ds;
            tinhTrang = new TinhTrang(txtPhong);
            this.Controls.Add(tinhTrang);

            kh = new KhachHangController();
            p = new PhongController();
            dp = new DatPhongController();

            txtMaNV.Text = manv;
            dateNgayTra.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dateNgayThue.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void themPhieuDatPhong(object sender, EventArgs e)
        {
            //Thêm một phiếu đặt vào danh sách
            string manv = txtMaNV.Text.ToString();
            string phong = txtPhong.Text.ToString();
            string dienthoai = txtDienThoai.Text.ToString();
            string hoten = txtHoTen.Text.ToString();
            string cmnd = txtCMND.Text.ToString();
            string ngaythue = dateNgayThue.Text.ToString();
            string ngaydi = dateNgayTra.Text.ToString();
            string rgxSDT = "^[0-9]{10,11}$";
            string rgxCMND = "^[0-9]{9,12}$";
            string rgxTen = @"[^\d\W_]+";
            bool mSDT = Regex.IsMatch(txtDienThoai.Text.ToString().Trim(), rgxSDT, RegexOptions.IgnoreCase);
            bool mCMND = Regex.IsMatch(txtCMND.Text.ToString().Trim(), rgxCMND, RegexOptions.IgnoreCase);
            bool mTen = Regex.IsMatch(txtHoTen.Text, rgxTen, RegexOptions.IgnoreCase);
            if (dateNgayThue.Value < DateTime.Now.Date) errorNgayThue.SetError(dateNgayThue, "Thời gian thuê không hợp lệ");
            else errorNgayThue.Clear();
            if (dateNgayTra.Value < dateNgayThue.Value) errorNgay.SetError(dateNgayTra, "Thời gian lựa chọn không phù hợp..");
            else errorNgay.Clear();
            if (!mSDT) errorDienThoai.SetError(txtDienThoai, "Số điện thoại trống hoặc không đúng.");
            else errorDienThoai.Clear();
            if (!mCMND) errorCMND.SetError(txtCMND, "CMND trống hoặc không đúng.");
            else errorCMND.Clear();
            if (!mTen) errorHoTen.SetError(txtHoTen, "Họ tên nhập chưa đúng.");
            else errorHoTen.Clear();
            if (tinhTrang.tblTinhTrang.CurrentRow.Cells[4].Value.ToString().Contains("Đã đặt")
                        || tinhTrang.tblTinhTrang.CurrentRow.Cells[4].Value.ToString().Contains("Đang thuê"))
                MessageBox.Show("Phòng chọn không cho phép đặt phiếu mới.");
            else if (mSDT && mCMND && mTen
                        && (!tinhTrang.tblTinhTrang.CurrentRow.Cells[4].Value.ToString().Contains("Đã đặt")
                        || !tinhTrang.tblTinhTrang.CurrentRow.Cells[4].Value.ToString().Contains("Đang thuê"))
                        && dateNgayTra.Value >= dateNgayThue.Value)
            {
                bool themKhach = kh.themKhachHang(cmnd, hoten, dienthoai);
                bool themPhieu = dp.themPhieuDat(cmnd, manv, phong, ngaythue, ngaydi);
                if (themKhach && themPhieu)
                {
                    p.doiTrangThaiPhong(phong, Option.P_DA_DAT);
                    tinhTrang.hienThiDanhSachPhong();
                    ds.hienThiThongTin();
                    MessageBox.Show("Đặt phòng thành công");
                    ds.Enabled = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi, vui lòng kiểm tra lại...");
                }
            }
                     
        }
        private void thoatDatPhong(object sender, FormClosedEventArgs e)
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
