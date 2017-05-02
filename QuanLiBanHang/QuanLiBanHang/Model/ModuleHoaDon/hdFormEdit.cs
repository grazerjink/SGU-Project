using QuanLiBanHang.Model;
using QuanLiBanHang.Model.Validation;
using System;
using System.Windows.Forms;

namespace QuanLiBanHang
{
    public partial class hdFormEdit : Form
    {
        private ModelStateDictionary ModelState;
        private IHoaDonService _hdService;
        private DialogToGetInfo info;
        private FormMain _main;

        public hdFormEdit()
        {
            if (_hdService == null)
            {
                _hdService = new HoaDonService(new ModelStateWrapper(this.ModelState));
            }
            InitializeComponent();
            InitData();
        }

        public hdFormEdit(FormMain main)
        {
            if (_hdService == null)
            {
                _hdService = new HoaDonService(new ModelStateWrapper(this.ModelState));
            }
            InitializeComponent();
            InitData();
            _main = main;
        }

        public hdFormEdit(IHoaDonService hdService) :this()
        {
            _hdService = hdService;
        }

        private void InitData()
        {
            info = new DialogToGetInfo(this);
            ModelState = new ModelStateDictionary();
            _hdService = new HoaDonService(new ModelStateWrapper(this.ModelState));
        }


        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            HoaDon hd = new HoaDon();
            hd.mahd = txtMaHD.Text.Trim();
            hd.makh = txtKhachHang.Text.Trim().Split('-')[0].Trim();
            hd.tongtien = decimal.Parse(txtTongTien.Text.Trim());
            _hdService.SuaHoaDon(hd);
            _main.dataGridView2.DataSource = _hdService.DanhSachHoaDon();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowKH_Click(object sender, EventArgs e)
        {
            try
            {
                info.dataGridView.ClearSelection();
                info.dataGridView.DataSource = _hdService.DanhSachKhachHang();
                info.setMaXacDinh("EDITHOADON");
                info.ShowDialog(this);
            }
            catch
            {

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtTongTien.Text = _hdService.layTongTienHoaDon(txtMaHD.Text.Trim()).ToString().Trim();
        }

        public void setTextToTextBox(HoaDon hd)
        {
            txtMaHD.Text = hd.mahd;
            txtMaNV.Text = hd.manv;
            txtKhachHang.Text = hd.makh + " - " + hd.KhachHang.tenkh;
            txtTongTien.Text = hd.tongtien.ToString();
        }
    }
}
