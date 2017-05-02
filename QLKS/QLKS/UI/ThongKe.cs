using BUS;
using DAO;
using System;
using System.Windows.Forms;

namespace QLKS.UI
{
    public partial class ThongKe : Form
    {
        private DangNhap dn;
        private string manv;
        private HoaDonController hd;
        private DichVuController dv;

        public ThongKe(DangNhap dn, string manv)
        {
            InitializeComponent();
            this.dn = dn;
            this.manv = manv;

            hd = new HoaDonController();
            dv = new DichVuController();

            cbxtknamNam.SelectedIndex = 0;
            cbxtkquyNam.SelectedIndex = 0;
            cbxtkquyQuy.SelectedIndex = 0;
            cbxtkthangNam.SelectedIndex = 0;
            cbxtkthangThang.SelectedIndex = 0;
            int thang = int.Parse(cbxtkthangThang.SelectedItem.ToString());
            int nam = int.Parse(cbxtkthangNam.SelectedItem.ToString());
            lblChiThu.Text = "Tổng chi thu tháng: ";
            tblThongKe.DataSource = hd.thongKeThang(thang, nam);
            pnlThang.Show();
            pnlNam.Hide();
            pnlQuy.Hide();
        }

        private void thoatThongKe(object sender, FormClosedEventArgs e)
        {
            dn.clearTaiKhoanMatKhau();
            dn.Show();
        }
        private void chonThongKeThang(object sender, EventArgs e)
        {
            
            if(rdThang.Checked)
            {
                pnlNam.Hide();
                pnlQuy.Hide();
                pnlThang.Show();
                cbxtknamNam.SelectedIndex = 0;
                cbxtkquyNam.SelectedIndex = 0;
                cbxtkquyQuy.SelectedIndex = 0;
                cbxtkthangNam.SelectedIndex = 0;
                cbxtkthangThang.SelectedIndex = 0;
                int thang = int.Parse(cbxtkthangThang.SelectedItem.ToString());
                int nam = int.Parse(cbxtkthangNam.SelectedItem.ToString());
                tblThongKe.DataSource = hd.thongKeThang(thang, nam);
                lblChiThu.Text = "Tổng chi thu tháng: ";
            }
        }
        private void chonThongKeQuy(object sender, EventArgs e)
        {
            if (rdQuy.Checked)
            {
                pnlNam.Hide();
                pnlQuy.Show();
                pnlThang.Hide();
                cbxtknamNam.SelectedIndex = 0;
                cbxtkquyNam.SelectedIndex = 0;
                cbxtkquyQuy.SelectedIndex = 0;
                cbxtkthangNam.SelectedIndex = 0;
                cbxtkthangThang.SelectedIndex = 0;
                int thang = int.Parse(cbxtkthangThang.SelectedItem.ToString());
                int nam = int.Parse(cbxtkthangNam.SelectedItem.ToString());
                tblThongKe.DataSource = hd.thongKeThang(thang, nam);
                lblChiThu.Text = "Tổng chi thu quý: ";
            }
        }
        private void chongThongKeNam(object sender, EventArgs e)
        {
            if (rdNam.Checked)
            {
                pnlNam.Show();
                pnlQuy.Hide();
                pnlThang.Hide();
                cbxtknamNam.SelectedIndex = 0;
                cbxtkquyNam.SelectedIndex = 0;
                cbxtkquyQuy.SelectedIndex = 0;
                cbxtkthangNam.SelectedIndex = 0;
                cbxtkthangThang.SelectedIndex = 0;
                int thang = int.Parse(cbxtkthangThang.SelectedItem.ToString());
                int nam = int.Parse(cbxtkthangNam.SelectedItem.ToString());
                tblThongKe.DataSource = hd.thongKeThang(thang, nam);
                lblChiThu.Text = "Tổng chi thu năm: ";
            }
        }
        private void thongKeChiThu(object sender, EventArgs e)
        {
            if (rdNam.Checked)
            {
                int nam = int.Parse(cbxtknamNam.SelectedItem.ToString());
                tblThongKe.DataSource = hd.thongKeNam(nam);

            }
            else if (rdQuy.Checked)
            {
                string quy = cbxtkquyQuy.SelectedItem.ToString();
                int nam = int.Parse(cbxtkquyNam.SelectedItem.ToString());
                tblThongKe.DataSource = hd.thongKeQuy(quy,nam);
            }
            else if(rdThang.Checked)
            {
                int thang = int.Parse(cbxtkthangThang.SelectedItem.ToString());
                int nam = int.Parse(cbxtkthangNam.SelectedItem.ToString());
                tblThongKe.DataSource = hd.thongKeThang(thang, nam);
            }
            double tongThuTienPhong = 0;
            double tongThuTienDichVu = 0;
            for (int i = 0; i < tblThongKe.RowCount; i++)
            {
                tongThuTienPhong += double.Parse(tblThongKe.Rows[i].Cells[3].Value.ToString().Trim());
                tongThuTienDichVu += double.Parse(tblThongKe.Rows[i].Cells[4].Value.ToString().Trim());
            }
            lblTongThuDichVu.Text = tongThuTienDichVu + ".00 VNĐ";
            lblTongThuTienPhong.Text = tongThuTienPhong + ".00 VNĐ";
            lblTongChiThu.Text = (tongThuTienDichVu+tongThuTienPhong)+".00 VNĐ";
        }
        private void timHoaDon(object sender, EventArgs e)
        {
            hoadon h = hd.layThongTinHoaDon(txtMaHoaDon.Text.ToUpper().Trim());
            if(h != null)
            {
                txtMaHD.Text = h.mahoadon.Trim();
                txtMaPhieuThue.Text = h.maphieuthue.Trim();
                txtNgayThanhToan.Text = h.ngaythanhtoan.Trim();
                txtNVThanhToan.Text = h.manv.Trim();

                txtCMND.Text = h.phieuthue.khachhang.cmnd.Trim();
                txtHoTen.Text = h.phieuthue.khachhang.hoten;
                txtDienThoai.Text = h.phieuthue.khachhang.dienthoai.Trim();

                txtPhong.Text = h.phieuthue.sophong.Trim();
                txtLoaiPhong.Text = h.phieuthue.phong.loaiphong.Trim();
                txtNgayThue.Text = h.phieuthue.ngaythue.Trim();
                txtTongNgayThue.Text = h.tongngaythue.Trim();
                txtTienPhong.Text = h.tongtienphong.Trim() + " VNĐ";

                tblDichVu.DataSource = dv.danhSachDaThem(h.phieuthue.maphieuthue);
                lblTongTienDichVu.Text = h.tongtiendichvu.Trim() + " VNĐ";
                lblTongCong.Text = (double.Parse(h.tongtienphong) + double.Parse(h.tongtiendichvu)) + ".00 VNĐ";               
            }
            else
            {
                MessageBox.Show("Hóa đơn này không tồn tại.","Thông báo");
            }
        }
        private void inHoaDon(object sender, EventArgs e)
        {
            MessageBox.Show("In hóa đơn thành công.");
        }
        private void xuatBaoCao(object sender, EventArgs e)
        {
            MessageBox.Show("Xuất báo cáo thành công.");
        }
        private void doiMatKhau(object sender, EventArgs e)
        {
            new DoiMatKhau(this, manv).Show();
            this.Enabled = false;
        }
        private void lamMoi(object sender, EventArgs e)
        {
            txtMaHoaDon.Text = null;
            txtMaHD.Text = null;
            txtMaPhieuThue.Text = null;
            txtNgayThanhToan.Text = null;
            txtNVThanhToan.Text = null;

            txtCMND.Text = null;
            txtHoTen.Text = null;
            txtDienThoai.Text = null;

            txtPhong.Text = null;
            txtLoaiPhong.Text = null;
            txtNgayThue.Text = null;
            txtTongNgayThue.Text = null;
            txtTienPhong.Text = null;

            tblDichVu.DataSource = null;
            lblTongTienDichVu.Text = "0.00 VNĐ";
            lblTongCong.Text = "0.00 VNĐ";
        }
    }
}
