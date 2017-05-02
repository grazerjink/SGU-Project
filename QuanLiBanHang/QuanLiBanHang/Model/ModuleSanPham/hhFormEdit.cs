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
    public partial class hhFormEdit : Form
    {
        private ModelStateDictionary ModelState;
        private ISanPhamService _spService;
        private FormMain _main;

        public hhFormEdit(ISanPhamService spService):this()
        {
            _spService = spService;
        }

        public hhFormEdit(FormMain main)
        {

            if (_spService == null)
            {
                _spService = new SanPhamService(new ModelStateWrapper(this.ModelState));
            }
            InitializeComponent();
            InitData();
            _main = main;

        }

        public hhFormEdit()
        {
            InitializeComponent();
            InitData();
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

        private void btnCapNhatSp_Click(object sender, EventArgs e)
        {
            HangHoa hh = _main.getHangHoa();
            try
            { 
                hh.tenhang = txtTenHang.Text.Trim();
                hh.hangsx = txtHangSanXuat.Text.Trim();
                hh.soluong = decimal.Parse(txtSoLuong.Text.Trim());
                hh.dongia = decimal.Parse(txtDonGia.Text.Trim());
                if (_spService.SuaSanPham(hh))
                {
                    _main.dataGridView.DataSource = _spService.DanhSachSanPham();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Số lượng và đơn giá đang trống hoặc sai cú pháp.", "Nhắc nhở");
            }
            ViewErrors();
        }

        public HangHoa getHangHoa()
        {
            HangHoa hh = new HangHoa();
            hh.tenhang = txtTenHang.Text;
            hh.hangsx = txtHangSanXuat.Text;
            hh.soluong = decimal.Parse(txtSoLuong.Text);
            hh.dongia = decimal.Parse(txtDonGia.Text);
            return hh;
        }

        public void setTextToTextBox(HangHoa hh)
        {
            txtTenHang.Text = hh.tenhang;
            txtHangSanXuat.Text = hh.hangsx;
            txtSoLuong.Text = hh.soluong.ToString();
            txtDonGia.Text = hh.dongia.ToString();
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
