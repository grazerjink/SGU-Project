using BUS;
using DAO;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace QLKS.UI
{
    public partial class TraPhong : Form
    {
        private DanhSach ds;
        private string manv;
        private string maphieuthue;
        private ThuePhongController tp;
        private PhongController p;
        private TraPhongController trp;
        private DichVuController dv;

        public TraPhong(DanhSach ds,string maphieuthue ,string manv)
        {
            InitializeComponent();
            this.ds = ds;
            this.maphieuthue = maphieuthue;
            this.manv = manv;
            txtNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");

            tp = new ThuePhongController();
            trp = new TraPhongController();
            p = new PhongController();
            dv = new DichVuController();
        }

        private void thanhToan(object sender, EventArgs e)
        {
            string maphieuthue = txtMaPhieu.Text;
            string manv = txtMaNV.Text;
            string tongngaythue = txtTongNgayThue.Text.Trim();
            string tongtienphong = txtTongTien.Text.ToString().Split(new string[] {" VNĐ" }, StringSplitOptions.None)[0];
            string tongtiendichvu = lblTongTienDichVu.Text.ToString().Split(new string[] { " VNĐ" }, StringSplitOptions.None)[0];
            string ngaythanhtoan = txtNgayLap.Text.Trim();
            string phong = txtPhong.Text.Trim();
            if (trp.themHoaDon(manv, maphieuthue, tongngaythue, tongtienphong, tongtiendichvu, ngaythanhtoan))
            {
                tp.doiTrangThaiPhieuThue(maphieuthue, Option.PT_DA_THANH_TOAN);
                p.doiTrangThaiPhong(phong, Option.P_SAN_SANG);
                MessageBox.Show("Thanh toán thành công.");

                ds.hienThiThongTin();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hệ thống có lỗi, liên hệ kỹ thuật...");
            }
        }
        private void huy(object sender, EventArgs e)
        {
            this.Close();
        }       
        private void thoatTraPhong(object sender, FormClosedEventArgs e)
        {
            ds.Enabled = true;
        }
        private void hienThiChiTiet(object sender, EventArgs e)
        {
            phieuthue p = tp.layThongTinPhieuThue(maphieuthue);
            txtMaPhieu.Text = maphieuthue;
            txtMaNV.Text = manv;
            txtPhong.Text = p.sophong.ToString().Trim();
            txtCMND.Text = p.cmnd.ToString().Trim();
            txtHoTen.Text = p.khachhang.hoten.ToString();
            txtDienThoai.Text = p.khachhang.dienthoai.ToString().Trim();
            txtNgayThue.Text = p.ngaythue.ToString().Trim();
            txtTienPhong.Text = p.phong.tienphong.Trim();

            // Tinh tong so ngay rui tinh tong thanh tien
            DateTime nThue = DateTime.ParseExact(txtNgayThue.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime nTra = DateTime.ParseExact(txtNgayLap.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            int songay = (nTra - nThue).Days;
            if (songay == 0) txtTongNgayThue.Text = "1";
            else txtTongNgayThue.Text = songay+"";
            double tongtienphong = double.Parse(txtTongNgayThue.Text) * double.Parse(txtTienPhong.Text);
            txtTongTien.Text = tongtienphong + ".00 VNĐ";

            // Hiện thông tin dịch vụ
            tblDichVu.DataSource = dv.danhSachDaThem(maphieuthue);
            double tongtiendv = 0;
            for(int i =0; i<tblDichVu.RowCount; i++)
            {
                tongtiendv += Double.Parse(tblDichVu.Rows[i].Cells[2].Value.ToString());
            }
            lblTongTienDichVu.Text = tongtiendv + ".00 VNĐ";
            lblTongCong.Text = (tongtienphong + tongtiendv) + ".00 VNĐ";
            
        }
    }
}
