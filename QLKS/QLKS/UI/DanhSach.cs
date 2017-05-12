using BUS;
using DAO;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace QLKS.UI
{
    public partial class DanhSach : Form
    {
        private DangNhap dn;
        private string manv;
        private DatPhongController dp;
        private ThuePhongController tp;
        private PhongController p;
        private TaiKhoanController tk;

        public DanhSach(DangNhap dn, string manv)
        {
            InitializeComponent();
            this.dn = dn;
            this.manv = manv;

            dp = new DatPhongController();
            tp = new ThuePhongController();
            p = new PhongController();
            tk = new TaiKhoanController();
            dp.huyDatPhongQuaHan();
            hienThiThongTin();
        }

        public void hienThiThongTin()
        {
            lblMaNV.Text = "Mã NV: " + manv;
            tblDatPhong.DataSource = dp.danhSachPhieuDat(null);
            tblDatPhong.Columns[0].HeaderText = "Mã phiếu đặt";
            tblDatPhong.Columns[1].HeaderText = "Mã nv";
            tblDatPhong.Columns[2].HeaderText = "CMND";
            tblDatPhong.Columns[3].HeaderText = "Họ tên";
            tblDatPhong.Columns[4].HeaderText = "Điện thoại";
            tblDatPhong.Columns[5].HeaderText = "Phòng";
            tblDatPhong.Columns[6].HeaderText = "Ngày nhận";
            tblDatPhong.Columns[7].HeaderText = "Ngày trả";
            tblDatPhong.Columns[8].HeaderText = "Trạng thái";

            tblThuePhong.DataSource = tp.danhSachPhieuThue(null);
            tblThuePhong.Columns[0].HeaderText = "Mã phiếu thuê";
            tblThuePhong.Columns[1].HeaderText = "Mã nv";
            tblThuePhong.Columns[2].HeaderText = "CMND";
            tblThuePhong.Columns[3].HeaderText = "Họ tên";
            tblThuePhong.Columns[4].HeaderText = "Điện thoại";
            tblThuePhong.Columns[5].HeaderText = "Phòng";
            tblThuePhong.Columns[6].HeaderText = "Ngày thuê";
            tblThuePhong.Columns[7].HeaderText = "Ngày trả";
            tblThuePhong.Columns[8].HeaderText = "Trạng thái";
        }
        private void thoatChuongTrinh(object sender, FormClosedEventArgs e)
        {
            // Tắt luôn chương trình
            
            dn.Close();
        }
        private void datPhong(object sender, EventArgs e)
        {
            //Tiến hành đặt phòng
            new DatPhong(this, manv).Show();
            this.Enabled = false;
        }
        private void thuePhong(object sender, EventArgs e)
        {
            //Tiến hành thuê phòng
            new ThuePhong(this,manv).Show();
            this.Enabled = false;
        }
        private void dangXuat(object sender, EventArgs e)
        {
            // Trở về đăng nhập
            dn.clearTaiKhoanMatKhau();
            dn.Show();
            this.Dispose();
        }
        private void doiMatKhau(object sender, EventArgs e)
        {
            new DoiMatKhau(this,manv).Show();
            this.Enabled = false;
        }
        private void trangThaiDaNhan(object sender, EventArgs e)
        {
            // Set trạng thái đã nhận trong ds phiếu đặt
            string dk1 = tblDatPhong.CurrentRow.Cells[8].Value.ToString();
            string ngayhientai = DateTime.Now.ToString("dd/MM/yyyy");
            bool dk2 = tblDatPhong.CurrentRow.Cells[6].Value.ToString().Trim().Equals(ngayhientai);
            if (dk1.Equals("Đã đặt") && dk2 == true)
            {
                string maphieudat = tblDatPhong.CurrentRow.Cells[0].Value.ToString();
                string manv = tblDatPhong.CurrentRow.Cells[1].Value.ToString();
                string cmnd = tblDatPhong.CurrentRow.Cells[2].Value.ToString().Trim();
                string phong = tblDatPhong.CurrentRow.Cells[5].Value.ToString();
                string ngaydenthue = tblDatPhong.CurrentRow.Cells[6].Value.ToString().Trim();
                string ngaydi = tblDatPhong.CurrentRow.Cells[7].Value.ToString().Trim();
                dp.doiTrangThaiPhieuDat(maphieudat, Option.PD_DA_NHAN);
                p.doiTrangThaiPhong(phong, Option.P_DANG_THUE);
                tp.themPhieuThue(cmnd, manv, phong, ngaydenthue, ngaydi);
                //Hiển thị lại table Đặt phòng
                hienThiThongTin();
            }
            else
            {
                MessageBox.Show("Không thực hiện được, phòng không thể giao trong hôm nay.","Thông báo");
            }

        }
        private void trangThaiDaHuy(object sender, EventArgs e)
        {
            if (tblDatPhong.CurrentRow.Cells[8].Value.ToString().Equals("Đã đặt"))
            {
                // Set trạng thái đã hủy trong danh sách phiếu đặt
                string maphieu = tblDatPhong.CurrentRow.Cells[0].Value.ToString();
                string phong = tblDatPhong.CurrentRow.Cells[5].Value.ToString();
                dp.doiTrangThaiPhieuDat(maphieu, Option.PD_DA_HUY);
                p.doiTrangThaiPhong(phong, Option.P_SAN_SANG);
                //Hiển thị lại table Đặt phòng
                hienThiThongTin();
            }
            else
            {
                MessageBox.Show("Không thể thực hiện được do khách đã nhận phòng.","Thông báo");
            }
        }
        private void trangThaiThanhToan(object sender, EventArgs e)
        {
            if (tblThuePhong.CurrentRow.Cells[8].Value.ToString().Equals("Đang thuê"))
            {
                string maphieuthue = tblThuePhong.CurrentRow.Cells[0].Value.ToString().Trim();
                // Set trạng thái đã thanh toán cho phiếu thuê 
                new TraPhong(this,maphieuthue,manv).Show();
                this.Enabled = false;
            }
            else
            {
                MessageBox.Show("Không thể thực hiện được do phòng đã thanh toán rồi.", "Thông báo");
            }
        }
        private void chonTrangThaiPhieuDat(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    DataGridView grid = sender as DataGridView;
                    grid.CurrentCell = grid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    Point pt = grid.PointToClient(Control.MousePosition);
                    ctmTrangThaiDat.Show(grid, pt.X, pt.Y);
                }
                catch { }
            }
        }
        private void chonTrangThaiPhieuThue(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    DataGridView grid = sender as DataGridView;
                    grid.CurrentCell = grid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    Point pt = grid.PointToClient(Control.MousePosition);
                    ctmTrangThaiThue.Show(grid, pt.X, pt.Y);
                }
                catch { }
            }
        }        
        private void chonHienThiDanhSachCanThanhToan(object sender, EventArgs e)
        {
            if (cbxDangThue.Checked) tblThuePhong.DataSource = tp.danhSachPhieuThue("");
            else tblThuePhong.DataSource = tp.danhSachPhieuThue(null);
        }
        private void chonHienThiDanhSachPhongDatHienTai(object sender, EventArgs e)
        {
            if (cbxDaDat.Checked) tblDatPhong.DataSource = dp.danhSachPhieuDat("");
            else tblDatPhong.DataSource = dp.danhSachPhieuDat(null);
        }
        private void themDichVu(object sender, EventArgs e)
        {            
            if (tblThuePhong.CurrentRow.Cells[8].Value.ToString().Equals("Đang thuê"))
            {
                string maphieuthue = tblThuePhong.CurrentRow.Cells[0].Value.ToString().Trim();
                string phong = tblThuePhong.CurrentRow.Cells[5].Value.ToString().Trim();
                new ThemDichVu(this, maphieuthue, phong).Show();
                this.Enabled = false;
            }
            else
            {
                MessageBox.Show("Không thể thực hiện được do phòng đã thanh toán rồi.");
            }
        }
    }
}
