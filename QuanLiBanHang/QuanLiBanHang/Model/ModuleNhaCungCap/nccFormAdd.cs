using QuanLiBanHang.Model;
using QuanLiBanHang.Model.Validation;
using System;
using System.Windows.Forms;

namespace QuanLiBanHang
{
    public partial class nccFormAdd : Form
    {
        private ModelStateDictionary ModelState;
        private INhaCungCapService _nccService;
        private FormMain _main;

        public nccFormAdd(INhaCungCapService nccService) :this()
        {
            _nccService = nccService;
        }

        public nccFormAdd(FormMain main)
        {

            if (_nccService == null)
            {
                _nccService = new NhaCungCapService(new ModelStateWrapper(this.ModelState));
            }
            InitializeComponent();
            InitData();
            _main = main;
        }

        public nccFormAdd()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            ModelState = new ModelStateDictionary();
            _nccService = new NhaCungCapService(new ModelStateWrapper(this.ModelState));
        }

        public void clearText()
        {
            txtTenNCC.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text="";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (_nccService.ThemNhaCungCap(getNhaCungCap()))
            {
                _main.dataGridView.DataSource = _nccService.DanhSachNhaCungCap();
                this.Close();
            }
            ViewErrors();
        }

        private NhaCungCap getNhaCungCap()
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.mancc = _nccService.SinhMaNhaCungCap().Trim();
            ncc.tenncc = txtTenNCC.Text.Trim();
            ncc.diachi = txtDiaChi.Text.Trim();
            ncc.sdt = txtDienThoai.Text.Trim();
            ncc.email = txtEmail.Text.Trim();
            return ncc;
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
                    case "DiaChi":
                        txtError.SetError(txtDiaChi, entry.Value);
                        break;
                    case "DienThoai":
                        txtError.SetError(txtDienThoai, entry.Value);
                        break;
                    case "Email":
                        txtError.SetError(txtEmail, entry.Value);
                        break;
                    case "IsDienThoai":
                        txtError.SetError(txtDienThoai, entry.Value);
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
