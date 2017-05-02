using System;
using QuanLiBanHang.Model;
using System.Windows.Forms;
using QuanLiBanHang.Model.Validation;
using System.Collections;

namespace QuanLiBanHang
{
    public partial class DialogToGetInfo : Form
    {
        String xacDinh;
        hdFormAdd _hd;
        pnFormAdd _pn;
        hdFormEdit _hdEdit;


        private IHoaDonService _hdService;
        private IPhieuNhapService _pnService;
        private ModelStateDictionary ModelState;

        public DialogToGetInfo()
        {
            InitializeComponent();
        }

        public DialogToGetInfo(hdFormAdd hd)
        {
            if (_hdService == null)
            {
                _hdService = new HoaDonService(new ModelStateWrapper(this.ModelState));
            }
            InitializeComponent();
            InitDataForHD();
            _hd = hd;
        }

        public DialogToGetInfo(hdFormEdit hdEdit)
        {
            if (_hdService == null)
            {
                _hdService = new HoaDonService(new ModelStateWrapper(this.ModelState));
            }

            if (_hdService == null)
            {
                _pnService = new PhieuNhapService(new ModelStateWrapper(this.ModelState));
            }

            InitializeComponent();
            InitDataForHD();
            btnRefesh.Enabled = false;
            btnNew.Enabled = false;
            _hdEdit = hdEdit;
        }

        public DialogToGetInfo(pnFormAdd pn)
        {
            InitializeComponent();
            InitDataForPN();
            _pn = pn;
        }

        public DialogToGetInfo(IHoaDonService hdService) : this()
        {
            _hdService = hdService;
        }

        public DialogToGetInfo(IPhieuNhapService pnService) : this()
        {
            _pnService = pnService;
        }

        private void InitDataForHD()
        {
            ModelState = new ModelStateDictionary();
            _hdService = new HoaDonService(new ModelStateWrapper(this.ModelState));
        }

        private void InitDataForPN()
        {
            ModelState = new ModelStateDictionary();
            _pnService = new PhieuNhapService(new ModelStateWrapper(this.ModelState));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            if (xacDinh.Equals("KHACHHANG"))
            {
                String kh = dataGridView.CurrentRow.Cells[0].Value.ToString() + " - " + dataGridView.CurrentRow.Cells[1].Value.ToString();
                _hd.txtKhachHang.Text = kh;
                
            }

            else if(xacDinh.Equals("SANPHAM"))
            {
                String sp = dataGridView.CurrentRow.Cells[0].Value.ToString() + " - " + dataGridView.CurrentRow.Cells[1].Value.ToString();
                _hd.txtTenSP.Text = sp;
                _hd.txtGiaBan.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            }

            else if (xacDinh.Equals("NHACUNGCAP"))
            {
                String ncc = dataGridView.CurrentRow.Cells[0].Value.ToString() + " - " + dataGridView.CurrentRow.Cells[1].Value.ToString();
                _pn.txtNhaCC.Text = ncc;
                this.Close();
            }

            else if (xacDinh.Equals("SANPHAM_"))
            {
                String sp = dataGridView.CurrentRow.Cells[0].Value.ToString() + " - " + dataGridView.CurrentRow.Cells[1].Value.ToString();
                _pn.txtSanPham.Text = sp;
                this.Close();
            }

            else if (xacDinh.Equals("EDITHOADON"))
            {
                String kh = dataGridView.CurrentRow.Cells[0].Value.ToString() + " - " + dataGridView.CurrentRow.Cells[1].Value.ToString();
                _hdEdit.txtKhachHang.Text = kh;
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setMaXacDinh(String maxd)
        {
            xacDinh = maxd;
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (xacDinh.Equals("KHACHHANG"))
            {
                String kh = dataGridView.CurrentRow.Cells[0].Value.ToString() + " - " + dataGridView.CurrentRow.Cells[1].Value.ToString();
                _hd.txtKhachHang.Text = kh;
                this.Close();
            }
            else if (xacDinh.Equals("SANPHAM"))
            {
                String sp = dataGridView.CurrentRow.Cells[0].Value.ToString() + " - " + dataGridView.CurrentRow.Cells[1].Value.ToString();
                _hd.txtTenSP.Text = sp;
                _hd.txtGiaBan.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
                this.Close();
            }

            else if (xacDinh.Equals("NHACUNGCAP"))
            {
                String ncc = dataGridView.CurrentRow.Cells[0].Value.ToString() + " - " + dataGridView.CurrentRow.Cells[1].Value.ToString();
                _pn.txtNhaCC.Text = ncc;
                this.Close();
            }

            else if (xacDinh.Equals("SANPHAM_"))
            {
                String sp = dataGridView.CurrentRow.Cells[0].Value.ToString() + " - " + dataGridView.CurrentRow.Cells[1].Value.ToString();
                _pn.txtSanPham.Text = sp;
                this.Close();
            }

            else if(xacDinh.Equals("EDITHOADON"))
            {
                String kh = dataGridView.CurrentRow.Cells[0].Value.ToString() + " - " + dataGridView.CurrentRow.Cells[1].Value.ToString();
                _hdEdit.txtKhachHang.Text = kh;
                this.Close();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            String str = txtTimKiem.Text;
            if (xacDinh.Equals("KHACHHANG"))
            {
                dataGridView.DataSource =  _hdService.TimKiemKhachHang(str);
            }
            else if (xacDinh.Equals("SANPHAM"))
            {
                dataGridView.DataSource = _hdService.TimKiemSanPham(str);
            }

            else if (xacDinh.Equals("NHACUNGCAP"))
            {
                dataGridView.DataSource = _pnService.TimKiemNhaCungCap(str);
            }

            else if (xacDinh.Equals("SANPHAM_"))
            {
                dataGridView.DataSource = _pnService.TimKiemSanPham(str);
            }

            else if (xacDinh.Equals("EDITHOADON"))
            {
                dataGridView.DataSource = _hdService.TimKiemSanPham(str);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (xacDinh.Equals("KHACHHANG"))
            {
                hdFormAdd._main.kh.ShowDialog();
            }
            else if (xacDinh.Equals("SANPHAM"))
            {
                hdFormAdd._main.hh.ShowDialog();
            }
            else if (xacDinh.Equals("NHACUNGCAP"))
            {
                pnFormAdd._main.ncc.ShowDialog();
            }

            else if (xacDinh.Equals("SANPHAM_"))
            {
                pnFormAdd._main.hh.ShowDialog();
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            if (xacDinh.Equals("KHACHHANG"))
            {
                dataGridView.ClearSelection();
                dataGridView.DataSource = _hdService.DanhSachKhachHang();
            }
            else if (xacDinh.Equals("SANPHAM"))
            {
                dataGridView.ClearSelection();
                dataGridView.DataSource = _hdService.DanhSachSanPham();
            }
            else if (xacDinh.Equals("NHACUNGCAP"))
            {
                dataGridView.ClearSelection();
                dataGridView.DataSource = _pnService.DanhSachNhaCungCap();
            }

            else if (xacDinh.Equals("SANPHAM_"))
            {
                dataGridView.ClearSelection();
                dataGridView.DataSource = _pnService.DanhSachSanPham();
            }

        }
    }
}
