using QuanLiBanHang.Model;
using QuanLiBanHang.Model.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiBanHang
{
    public partial class nvFormEdit : Form
    {
        private ModelStateDictionary ModelState;
        private INhanVienService _nvService;
        private FormMain _main;

        public nvFormEdit(INhanVienService nvService) :this()
        {
            _nvService = nvService;
        }

        public nvFormEdit(FormMain main)
        {

            if (_nvService == null)
            {
                _nvService = new NhanVienService(new ModelStateWrapper(this.ModelState));
            }
            InitializeComponent();
            InitData();
            _main = main;
        }

        public nvFormEdit()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            ModelState = new ModelStateDictionary();
            _nvService = new NhanVienService(new ModelStateWrapper(this.ModelState));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public void setTextToTextBox(NhanVien nv)
        {
            txtTenNV.Text = nv.tennv.Trim();
            txtNgaySinh.Text = nv.ngaysinh.ToShortDateString();
            txtDiaChi.Text = nv.diachi.Trim();
            try
            {
                txtDienThoai.Text = nv.dienthoai.Trim();
            } catch
            {
                txtDienThoai.Text = " ";
            }
            if(nv.chucvu == 2)
            {
                radQuanLi.Select();
            } else
            {
                radNhanVien.Select();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NhanVien nv = _main.getNhanVien();
            nv.tennv = txtTenNV.Text.Trim();
            nv.diachi = txtDiaChi.Text.Trim();
            nv.dienthoai = txtDienThoai.Text.Trim();
            if (radQuanLi.Checked)
                nv.chucvu = 2;
            else
                nv.chucvu = 1;
            nv.ngaysinh = DateTime.Parse(txtNgaySinh.Text);
            if (_nvService.SuaNhanVien(nv))
            {
                _main.dataGridView.DataSource = _nvService.DanhSachNhanVien();
                this.Close();
            }
            ViewErrors();
        }

        private void ViewErrors()
        {
            txtError.Clear();
            foreach (var entry in ModelState)
            {
                switch (entry.Key)
                {
                    case "TenNV":
                        txtError.SetError(txtTenNV, entry.Value);
                        break;
                    case "NgaySinh":
                        txtError.SetError(txtNgaySinh, entry.Value);
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
    }
}
