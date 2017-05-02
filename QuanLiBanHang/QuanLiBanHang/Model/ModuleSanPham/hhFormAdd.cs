using QuanLiBanHang.Model;
using QuanLiBanHang.Model.Validation;
using System;
using System.Windows.Forms;

namespace QuanLiBanHang
{
    public partial class hhFormAdd : Form
    {
        private ISanPhamService _spService;
        private ModelStateDictionary ModelState;
        private FormMain _main;

        public hhFormAdd(ISanPhamService spService):this()
        {
            _spService = spService;
        }

        public hhFormAdd()
        {
            if (_spService == null)
            {
                _spService = new SanPhamService(new ModelStateWrapper(this.ModelState));
            }
            InitializeComponent();
            InitData();
        }

        public hhFormAdd(FormMain main)
        {

            if (_spService == null)
            {
                _spService = new SanPhamService(new ModelStateWrapper(this.ModelState));
            }
            InitializeComponent();
            InitData();
            _main = main;
        }

        private void InitData()
        {
            ModelState = new ModelStateDictionary();
            _spService = new SanPhamService(new ModelStateWrapper(this.ModelState));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemSp_Click(object sender, EventArgs e)
        {
            if (getHangHoa() != null)
            { 
                if (_spService.ThemSanPham(getHangHoa()))
                {
                    _main.dataGridView.DataSource = _spService.DanhSachSanPham();
                    this.Close();
                }
            } else
            {
                MessageBox.Show("Số lượng và đơn giá không được nhập kí tự.", "Thông báo lỗi");
            }
            ViewErrors();
        }

        public HangHoa getHangHoa()
        {
            HangHoa hh = new HangHoa();
            try
            {
                hh.mahang = _spService.SinhMaSanPham().Trim();
                hh.tenhang = txtTenHang.Text.Trim();
                hh.hangsx = txtHangSanXuat.Text.Trim();
                hh.soluong = txtSoLuong.Text == "" ? 0 : decimal.Parse(txtSoLuong.Text);
                hh.dongia = txtDonGia.Text == "" ? 0 : decimal.Parse(txtDonGia.Text);
                return hh;
            } catch
            {
                return null;
            }
                
        }
        
        public void clearText()
        {
            txtDonGia.Text = "";
            txtHangSanXuat.Text = "";
            txtSoLuong.Text = "";
            txtTenHang.Text = "";
        }

        private void ViewErrors()
        {
            txtError.Clear();
            foreach (var entry in ModelState)
            {
                switch (entry.Key)
                {
                    case "TenHang":
                        txtError.SetError(txtTenHang, entry.Value);
                        break;
                    case "HangSX":
                        txtError.SetError(txtHangSanXuat, entry.Value);
                        break;
                    case "SoLuong":
                        txtError.SetError(txtSoLuong, entry.Value);
                        break;
                    case "DonGia":
                        txtError.SetError(txtDonGia, entry.Value);
                        break;
                    case "IsDonGia":
                        txtError.SetError(txtDonGia, entry.Value);
                        break;
                    case "IsSoLuong":
                        txtError.SetError(txtSoLuong, entry.Value);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
