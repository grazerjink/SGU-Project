using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiBanHang.Model;
using QuanLiBanHang.Model.Validation;

namespace QuanLiBanHang
{
    public partial class pnFormAdd : Form
    {
        private ModelStateDictionary ModelState;
        private IPhieuNhapService _pnService;
        private ISanPhamService _spService;
        static public FormMain _main;
        private DialogToGetInfo info;

        public pnFormAdd(ISanPhamService spService):this()
        {
            _spService = spService;
            //btnThemTiep.Hide();
            //btnShowKH.Enabled = true;
        }

        public pnFormAdd(IPhieuNhapService pnService) :this()
        {
            _pnService = pnService;
            //btnThemTiep.Hide();
            //btnShowKH.Enabled = true;
        }

        public pnFormAdd(FormMain main)
        {

            if (_pnService == null)
            {
                _pnService = new PhieuNhapService(new ModelStateWrapper(this.ModelState));
            }
            if (_spService == null)
            {
                _spService = new SanPhamService(new ModelStateWrapper(this.ModelState));
            }
            InitializeComponent();
            InitData();
            //txtMaHD.Text = _hdService.SinhMaHoaDon();
            txtMaNV.Text = FormLogin.ma;
            //btnThemTiep.Hide();
            //btnShowKH.Enabled = true;
            _main = main;
        }

        public pnFormAdd()
        {
            InitializeComponent();
            InitData();
            //txtMaHD.Text = _hdService.SinhMaHoaDon();
            txtMaNV.Text = FormLogin.ma;
            //btnThemTiep.Hide();
            //btnShowKH.Enabled = true;
        }

        private void InitData()
        {
            //btnShowKH.Enabled = true;
            //btnThemTiep.Text = "Tiếp tục";
            info = new DialogToGetInfo(this);
            ModelState = new ModelStateDictionary();
            _pnService = new PhieuNhapService(new ModelStateWrapper(this.ModelState));
            _spService = new SanPhamService(new ModelStateWrapper(this.ModelState));
        }

        private void btnShowNCC_Click(object sender, EventArgs e)
        {
            try
            {
                info.dataGridView.ClearSelection();
                info.dataGridView.DataSource = _pnService.DanhSachNhaCungCap();
                info.setMaXacDinh("NHACUNGCAP");
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
                info.dataGridView.DataSource = _pnService.DanhSachSanPham();
                info.setMaXacDinh("SANPHAM_");
                info.ShowDialog();
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtThanhTien.Text = (decimal.Parse(txtSoLuong.Text.Trim()) * decimal.Parse(txtGiaNhap.Text.Trim())).ToString();
            }
            catch
            {

            }
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {

        }

        private bool themChiTiet()
        {
            if (MessageBox.Show("Đã thêm thành công. Có thêm tiếp chi tiết không ?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
