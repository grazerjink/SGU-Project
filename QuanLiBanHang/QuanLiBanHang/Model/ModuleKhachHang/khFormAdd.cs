using QuanLiBanHang.Model;
using QuanLiBanHang.Model.Validation;
using System;
using System.Windows.Forms;

namespace QuanLiBanHang
{
    public partial class khFormAdd : Form
    {
        private ModelStateDictionary ModelState;
        private IKhachHangService _khService;
        private FormMain _main;

        public khFormAdd(IKhachHangService khService) :this()
        {
            _khService = khService;
        }

        public khFormAdd(FormMain main)
        {
            if (_khService == null)
            {
                _khService = new KhachHangService(new ModelStateWrapper(this.ModelState));
            }
            InitializeComponent();
            InitData();
            _main = main;
        }

        public khFormAdd()
        {
            if (_khService == null)
            {
                _khService = new KhachHangService(new ModelStateWrapper(this.ModelState));
            }
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            ModelState = new ModelStateDictionary();
            _khService = new KhachHangService(new ModelStateWrapper(this.ModelState));
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void clearText()
        {
            txtTenKH.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            cbTiemNang.Checked = false;
        }

        private KhachHang getKhachHang()
        {
            KhachHang kh = new KhachHang();
            kh.makh = _khService.SinhMaKhachHang().Trim();
            kh.tenkh = txtTenKH.Text.Trim();
            kh.diachi = txtDiaChi.Text.Trim();
            kh.dienthoai = txtDienThoai.Text.Trim();
            if(cbTiemNang.Checked)
            {
                kh.tiemnang = 1;
            } else
            {
                kh.tiemnang = 0;
            }
            return kh;
        }

        private void ViewErrors()
        {
            txtError.Clear();
            foreach (var entry in ModelState)
            {
                switch (entry.Key)
                {
                    case "TenKH":
                        txtError.SetError(txtTenKH, entry.Value);
                        break;
                    case "DiaChi":
                        txtError.SetError(txtDiaChi, entry.Value);
                        break;
                    case "DienThoai":
                        txtError.SetError(txtDienThoai, entry.Value);
                        break;
                    default:
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_khService.ThemKhachHang(getKhachHang()))
            {
                _main.dataGridView.DataSource = _khService.DanhSachKhachHang();
                this.Close();
            }
            ViewErrors();
        }
    }
}
