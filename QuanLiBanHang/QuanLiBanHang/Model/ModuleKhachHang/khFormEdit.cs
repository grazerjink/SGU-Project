using QuanLiBanHang.Model;
using QuanLiBanHang.Model.Validation;
using System;
using System.Windows.Forms;

namespace QuanLiBanHang
{
    public partial class khFormEdit : Form
    {
        private ModelStateDictionary ModelState;
        private IKhachHangService _khService;
        private FormMain _main;

        public khFormEdit(IKhachHangService khService) :this()
        {
            _khService = khService;
        }

        public khFormEdit(FormMain main)
        {
            if (_khService == null)
            {
                _khService = new KhachHangService(new ModelStateWrapper(this.ModelState));
            }
            InitializeComponent();
            InitData();
            _main = main;
        }

        public khFormEdit()
        {
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

        public void setTextToTextBox(KhachHang kh)
        {
            txtTenKH.Text = kh.tenkh.Trim();
            txtDiaChi.Text = kh.diachi.Trim();
            if (kh.tiemnang == 1)
            {
                cbTiemNang.Checked = true;
            } else
            {
                cbTiemNang.Checked = false;
            }

            try
            {
                txtDienThoai.Text = kh.dienthoai.Trim();
            }
            catch
            {
                txtDienThoai.Text = "";
            }
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
            KhachHang kh = _main.getKhachHang();
            kh.tenkh = txtTenKH.Text.Trim();
            kh.diachi = txtDiaChi.Text.Trim();
            kh.dienthoai = txtDienThoai.Text.Trim();
            if (cbTiemNang.Checked)
            {
                kh.tiemnang = 1;
            } else
            {
                kh.tiemnang = 0;
            }

            if (_khService.SuaKhachHang(kh))
            {
                _main.dataGridView.DataSource = _khService.DanhSachKhachHang();
                this.Close();
            }
            ViewErrors();
        }
    }
}
