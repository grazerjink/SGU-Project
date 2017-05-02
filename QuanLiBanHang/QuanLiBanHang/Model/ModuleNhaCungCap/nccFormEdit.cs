using QuanLiBanHang.Model;
using QuanLiBanHang.Model.Validation;
using System;
using System.Windows.Forms;

namespace QuanLiBanHang
{
    public partial class nccFormEdit : Form
    {
        private ModelStateDictionary ModelState;
        private INhaCungCapService _nccService;
        private FormMain _main;

        public nccFormEdit(INhaCungCapService nccService) :this()
        {
            _nccService = nccService;
        }

        public nccFormEdit(FormMain main)
        {

            if (_nccService == null)
            {
                _nccService = new NhaCungCapService(new ModelStateWrapper(this.ModelState));
            }
            InitializeComponent();
            InitData();
            _main = main;
        }

        public nccFormEdit()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            ModelState = new ModelStateDictionary();
            _nccService = new NhaCungCapService(new ModelStateWrapper(this.ModelState));
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = _main.getNhaCungCap();
            ncc.tenncc = txtTenNCC.Text.Trim();
            ncc.diachi = txtDiaChi.Text.Trim();
            ncc.sdt = txtDienThoai.Text.Trim();
            ncc.email = txtEmail.Text.Trim();

            if (_nccService.SuaNhaCungCap(ncc))
            {
                _main.dataGridView.DataSource = _nccService.DanhSachNhaCungCap();
                this.Close();
            }
            ViewErrors();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setTextToTextBox(NhaCungCap ncc)
        {
            txtTenNCC.Text = ncc.tenncc.Trim();
            txtDiaChi.Text = ncc.diachi.Trim();
            txtEmail.Text = ncc.email.Trim();
            try
            {
                txtDienThoai.Text = ncc.sdt.Trim();
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
                    case "TenNCC":
                        txtError.SetError(txtTenNCC, entry.Value);
                        break;
                    case "DienThoai":
                        txtError.SetError(txtDienThoai, entry.Value);
                        break;
                    case "IsDienThoai":
                        txtError.SetError(txtDienThoai, entry.Value);
                        break;
                    case "DiaChi":
                        txtError.SetError(txtDiaChi, entry.Value);
                        break;
                    case "Email":
                        txtError.SetError(txtEmail, entry.Value);
                        break;
                    case "IsEmail":
                        txtError.SetError(txtEmail, entry.Value);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
