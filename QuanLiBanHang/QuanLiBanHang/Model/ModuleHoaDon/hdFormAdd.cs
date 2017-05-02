using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiBanHang.Model;
using System.Windows.Forms;
using QuanLiBanHang.Model.Validation;

namespace QuanLiBanHang
{
    public partial class hdFormAdd : Form
    {
        private ModelStateDictionary ModelState;
        private IHoaDonService _hdService;
        private ISanPhamService _spService;
        static public FormMain _main;
        private DialogToGetInfo info;

        public hdFormAdd(ISanPhamService spService):this()
        {
            _spService = spService;
            btnThemTiep.Hide();
            btnShowKH.Enabled = true;
        }

        public hdFormAdd(IHoaDonService hdService) :this()
        {
            _hdService = hdService;
            btnThemTiep.Hide();
            btnShowKH.Enabled = true;
        }

        public hdFormAdd(FormMain main)
        {

            if (_hdService == null)
            {
                _hdService = new HoaDonService(new ModelStateWrapper(this.ModelState));
            }
            if (_spService == null)
            {
                _spService = new SanPhamService(new ModelStateWrapper(this.ModelState));
            }
            InitializeComponent();
            InitData();
            txtMaHD.Text = _hdService.SinhMaHoaDon();
            txtMaNV.Text = FormLogin.ma;
            btnThemTiep.Hide();
            btnShowKH.Enabled = true;
            _main = main;
        }
        
        public hdFormAdd()
        {
            InitializeComponent();
            InitData();
            txtMaHD.Text = _hdService.SinhMaHoaDon();
            txtMaNV.Text = FormLogin.ma;
            btnThemTiep.Hide();
            btnShowKH.Enabled = true;
        }

        private void InitData()
        {
            btnShowKH.Enabled = true;
            btnThemTiep.Text = "Tiếp tục";
            info = new DialogToGetInfo(this);
            ModelState = new ModelStateDictionary();
            _hdService = new HoaDonService(new ModelStateWrapper(this.ModelState));
            _spService = new SanPhamService(new ModelStateWrapper(this.ModelState));
        }

        private void btnShowKH_Click(object sender, EventArgs e)
        {
            try
            {
                info.dataGridView.ClearSelection();
                info.dataGridView.DataSource = _hdService.DanhSachKhachHang();
                info.setMaXacDinh("KHACHHANG");
                info.ShowDialog();
            }
            catch
            {

            }
        }
        private void btnShowSP_Click(object sender, EventArgs e)
        {
            try
            {
                info.dataGridView.ClearSelection();
                info.dataGridView.DataSource = _hdService.DanhSachSanPham();
                info.setMaXacDinh("SANPHAM");
                info.ShowDialog();
            }
            catch
            {

            }
        }

        private String mahd = null;

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            //Them Hoa Don và hỏi có thêm chi tiết không ?
            if (txtTenSP.Text == "" || txtKhachHang.Text == "")
            {
                MessageBox.Show("Chưa thêm thông tin sản phẩm....!", "Thông Báo lỗi");
            }
            else
            {
                try
                {
                    mahd = _hdService.SinhMaHoaDon();
                    HoaDon hd = new HoaDon();
                    Ct_HoaDon cthd = new Ct_HoaDon();
                    hd.mahd = mahd;
                    hd.makh = txtKhachHang.Text.Trim().Split('-')[0];
                    hd.manv = txtMaNV.Text.Trim();
                    hd.ngayxuat = DateTime.Parse(txtNgayLap.Text.Trim());
                    hd.tongtien = 0;

                    cthd.mahang = txtTenSP.Text.Trim().Split('-')[0];
                    cthd.mahd = mahd;
                    cthd.soluong = decimal.Parse(txtSoLuong.Text.Trim());
                    cthd.giaban = decimal.Parse(txtGiaBan.Text.Trim());
                    cthd.thanhtien = decimal.Parse(txtThanhTien.Text.Trim());

                    if (_hdService.ThemHoaDon(hd))
                    {
                        _main.dataGridView2.DataSource = _hdService.DanhSachHoaDon();
                        if (_hdService.ThemCTHoaDon(cthd))
                        {
                            hd.tongtien = _hdService.layTongTienHoaDon(hd.mahd.Trim());
                            _hdService.SuaHoaDon(hd);
                            _main.dataGridView2.DataSource = _hdService.DanhSachHoaDon();
                            if (_spService.CapNhatSoLuong(cthd.mahang.Trim(),"HOADON",cthd.soluong))
                            {
                                _main.dataGridView.DataSource = _spService.DanhSachSanPham();
                            }
                            if (themChiTiet())
                            {
                                txtTenSP.Clear();
                                txtThanhTien.Text = "0";
                                txtSoLuong.Text = "0";
                                txtGiaBan.Text = "0";
                                txtTenSP.Focus();
                                btnThemTiep.Show();
                            }
                            else
                            {
                                btnThemTiep.Hide();
                                _main.dataGridView2.DataSource = _hdService.DanhSachHoaDon();
                                this.Close();
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Số lượng đã nhập sai, kiểm tra lại.", "Thông Báo lỗi");
                }
            }
        }

        private void btnThemTiep_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text != "" || txtKhachHang.Text != "")
            {
                try
                {
                    Ct_HoaDon cthd = new Ct_HoaDon();
                    cthd.mahang = txtTenSP.Text.Trim().Split('-')[0];
                    cthd.mahd = mahd;
                    cthd.soluong = decimal.Parse(txtSoLuong.Text.Trim());
                    cthd.giaban = decimal.Parse(txtGiaBan.Text.Trim());
                    cthd.thanhtien = decimal.Parse(txtThanhTien.Text.Trim());
                    if (_hdService.ThemCTHoaDon(cthd))
                    {
                        HoaDon hd = new HoaDon();
                        hd.mahd = mahd;
                        hd.makh = txtKhachHang.Text.Trim().Split('-')[0];
                        hd.tongtien = _hdService.layTongTienHoaDon(hd.mahd.Trim());
                        _hdService.SuaHoaDon(hd);
                        _main.dataGridView2.DataSource = _hdService.DanhSachHoaDon();
                        if (_spService.CapNhatSoLuong(cthd.mahang.Trim(), "HOADON", cthd.soluong))
                        {
                            _main.dataGridView.DataSource = _spService.DanhSachSanPham();
                        }
                        _main.dataGridDetail.DataSource = _hdService.DanhSachCTHoaDon(cthd.mahd, txtMaNV.Text.Trim(), txtKhachHang.Text.Trim().Split('-')[0]);
                        if (themChiTiet())
                        {
                            txtTenSP.Clear();
                            txtThanhTien.Text = "0";
                            txtSoLuong.Text = "0";
                            txtGiaBan.Text = "0";
                            txtTenSP.Focus();
                            btnThemTiep.Show();
                        }
                        else
                        {
                            btnThemTiep.Hide();
                            this.Close();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Số lượng đã nhập sai, kiểm tra lại.", "Thông Báo lỗi");
                }
            }
            else
            {
                MessageBox.Show("Chưa thêm thông tin sản phẩm....!", "Thông Báo lỗi");
            }
        }

        private bool themChiTiet()
        {
            if(MessageBox.Show("Đã thêm thành công. Có thêm tiếp chi tiết không ?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                return true;
            } else
            {
                return false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void clearText()
        {
            txtTenSP.Clear();
            txtKhachHang.Clear();
            txtThanhTien.Text = "0";
            txtSoLuong.Text = "0";
            txtGiaBan.Text = "0";
        }
        
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtThanhTien.Text = (decimal.Parse(txtSoLuong.Text.Trim()) * decimal.Parse(txtGiaBan.Text.Trim())).ToString();
            }
            catch
            {

            }
        }

        public void setTextBox(String mahd, String manv, String kh, String ngaylap)
        {
            this.mahd = mahd;
            txtMaHD.Text = mahd;
            txtMaNV.Text = manv;
            txtNgayLap.Text = ngaylap;
            txtKhachHang.Text =  kh;
        }
    }
}
