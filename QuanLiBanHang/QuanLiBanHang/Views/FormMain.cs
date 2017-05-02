using System;
using System.Drawing;
using QuanLiBanHang.Model;
using System.Windows.Forms;
using QuanLiBanHang.Model.Validation;

namespace QuanLiBanHang
{
    public partial class FormMain : Form
    {
        public static readonly String HANGHOA = "Hàng hóa";
        public static readonly String HOADON = "Hóa đơn";
        public static readonly String PHIEUNHAP = "Phiếu nhập";
        public static readonly String KHACHHANG = "Khách hàng";
        public static readonly String NHACUNGCAP = "Nhà cung cấp";
        public static readonly String NHANVIEN = "Nhân viên";

        FormLogin login;
        public hhFormAdd hh;
        nvFormAdd nv;
        public khFormAdd kh;
        public nccFormAdd ncc;
        pnFormAdd pn;
        hdFormAdd hd;

        hhFormEdit hhEdit;
        nvFormEdit nvEdit;
        nccFormEdit nccEdit;
        khFormEdit khEdit;
        hdFormEdit hdEdit;
                    
        private ISanPhamService _spService;
        private INhanVienService _nvService;
        private IKhachHangService _khService;
        private INhaCungCapService _nccService;
        private IHoaDonService _hdService;
        private IPhieuNhapService _pnService;
        private ModelStateDictionary ModelState;

        public FormMain(FormLogin login)
        {

            hh = new hhFormAdd(this);
            nv = new nvFormAdd(this);
            kh = new khFormAdd(this);
            ncc = new nccFormAdd(this);
            pn = new pnFormAdd(this);
            hd = new hdFormAdd(this);
            hhEdit = new hhFormEdit(this);
            nvEdit = new nvFormEdit(this);
            nccEdit = new nccFormEdit(this);
            khEdit = new khFormEdit(this);
            hdEdit = new hdFormEdit(this);
            //pnEdit = new pnFormEdit(this);

            if (_spService == null)
            {
                _spService = new SanPhamService(new ModelStateWrapper(this.ModelState));
            }
            if (_nvService == null)
            {
                _nvService = new NhanVienService(new ModelStateWrapper(this.ModelState));
            }
            if (_nccService == null)
            {
                _nccService = new NhaCungCapService(new ModelStateWrapper(this.ModelState));
            }
            if (_khService == null)
            {
                _khService = new KhachHangService(new ModelStateWrapper(this.ModelState));
            }
            if (_hdService == null)
            {
                _hdService = new HoaDonService(new ModelStateWrapper(this.ModelState));
            }
            if (_pnService == null)
            {
                _pnService = new PhieuNhapService(new ModelStateWrapper(this.ModelState));
            }
            InitializeComponent();
            InitData();
            InitControls();
            this.login = login;
            this.login.Hide();
            
        }

        private void InitData()
        {
            ModelState = new ModelStateDictionary();
            _spService = new SanPhamService(new ModelStateWrapper(this.ModelState));
            _nvService = new NhanVienService(new ModelStateWrapper(this.ModelState));
            _nccService = new NhaCungCapService(new ModelStateWrapper(this.ModelState));
            _khService = new KhachHangService(new ModelStateWrapper(this.ModelState));
            _hdService = new HoaDonService(new ModelStateWrapper(this.ModelState));
            _pnService = new PhieuNhapService(new ModelStateWrapper(this.ModelState));
        }

        private void InitControls()
        {
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView2.ReadOnly = true;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridDetail.ReadOnly = true;
            dataGridDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            panelDetail.Visible = true;
            dataGridDetail.Visible = true;
            dataGridView2.DataSource = _hdService.DanhSachHoaDon();
            btnThongKe.Show();
        }

        public FormMain(ISanPhamService spService) : this()
        {
            _spService = spService;
        }

        public FormMain(INhanVienService nvService) : this()
        {
            _nvService = nvService;
        }

        public FormMain(INhaCungCapService nccService) : this()
        {
            _nccService = nccService;
        }

        public FormMain(IKhachHangService khService) : this()
        {
            _khService = khService;
        }

        public FormMain(IPhieuNhapService pnService) : this()
        {
            _pnService = pnService;
        }

        public FormMain()
        {
            InitializeComponent();
            login.Hide();
            panelDetail.Visible = true;
            dataGridDetail.Visible = true;
            dataGridView2.DataSource = _hdService.DanhSachHoaDon();
        }
        
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            lblHienHanh.Text = "Hóa đơn";
            txtTimKiem.Clear();
            dataGridView2.DataSource = _hdService.DanhSachHoaDon();
            dataGridDetail.DataSource = null;
        }
        
        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            lblHienHanh.Text = "Phiếu nhập";
            txtTimKiem.Clear();
            dataGridView2.DataSource = _pnService.DanhSachPhieuNhap();
            dataGridDetail.DataSource = null;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            lblHienHanh.Text = "Nhân viên";
            txtTimKiem.Clear();
            dataGridView.DataSource = _nvService.DanhSachNhanVien();
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            lblHienHanh.Text = "Nhà cung cấp";
            dataGridView.DataSource = _nccService.DanhSachNhaCungCap();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            lblHienHanh.Text = "Khách hàng";
            dataGridView.DataSource = _khService.DanhSachKhachHang();
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            lblHienHanh.Text = "Hàng hóa";
            dataGridView.DataSource = _spService.DanhSachSanPham();

        }

        //Cần code mở ra xem
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            String str = txtTimKiem.Text.ToString();
            
            if (lblHienHanh.Text.Equals(HOADON))
            {
                if (str == "" || str == null)
                {
                    dataGridView2.DataSource = _hdService.DanhSachHoaDon();
                    dataGridDetail.DataSource = null;
                }
                else
                {
                    dataGridView2.DataSource = _hdService.TimKiemHoaDon(str);
                    try 
                    {
                        if (dataGridView2.DataSource != null)
                        {
                            String mahd = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                            String manv = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                            String makh = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                            dataGridDetail.DataSource = _hdService.DanhSachCTHoaDon(mahd, manv, makh);
                        }
                    }
                    catch
                    {
                        dataGridDetail.DataSource = null;
                    }
                }
            }

            if (lblHienHanh.Text.Equals(PHIEUNHAP))
            {
                if (str == "" || str == null)
                {
                    dataGridView2.DataSource = _pnService.DanhSachPhieuNhap();
                    dataGridDetail.DataSource = null;
                }
                else
                {
                    dataGridView2.DataSource = _pnService.TimKiemPhieuNhap(str);
                    try
                    {
                        if (dataGridView2.DataSource != null)
                        {
                            String mapn = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                            String manv = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                            String mancc = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                            dataGridDetail.DataSource = _pnService.DanhSachCTPhieuNhap(mapn, manv, mancc);
                        }
                    }
                    catch
                    {
                        dataGridDetail.DataSource = null;
                    }
                }
            }

            if (lblHienHanh.Text.Equals(HANGHOA))
            {
                if (str == "" || str == null)
                    dataGridView.DataSource = _spService.DanhSachSanPham();
                else
                    dataGridView.DataSource = _spService.TimKiemSanPham(str);
            }

            if (lblHienHanh.Text.Equals(KHACHHANG))
            {
                if (str == "" || str == null)
                    dataGridView.DataSource = _khService.DanhSachKhachHang();
                else
                    dataGridView.DataSource = _khService.TimKiemKhachHang(str);
            }

            if (lblHienHanh.Text.Equals(NHACUNGCAP))
            {
                if (str == "" || str == null)
                    dataGridView.DataSource = _nccService.DanhSachNhaCungCap();
                else
                    dataGridView.DataSource = _nccService.TimKiemNhaCungCap(str);
            }

            if (lblHienHanh.Text.Equals(NHANVIEN))
            {
                if (str == "" || str == null)
                    dataGridView.DataSource = _nvService.DanhSachNhanVien();
                else
                    dataGridView.DataSource = _nvService.TimKiemNhanVien(str);
            }
        }

        //Cần code mở ra xem
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lblHienHanh.Text == NHANVIEN)
            {
                nv.clearText();
                if (!nv.Visible)
                {
                    nv.ShowDialog();
                }
            }

            if (lblHienHanh.Text == HANGHOA)
            {
                hh.clearText();
                if (!hh.Visible)
                    hh.ShowDialog();
            }

            if (lblHienHanh.Text == KHACHHANG)
            {
                kh.clearText();
                if (!kh.Visible)
                    kh.ShowDialog();
            }

            if (lblHienHanh.Text == NHACUNGCAP)
            {
                ncc.clearText();
                if (!ncc.Visible)
                    ncc.ShowDialog();
            }

            if (lblHienHanh.Text == HOADON)
            {
                if (!hd.Visible)
                {
                    hd.clearText();
                    DateTime dt = DateTime.Now;
                    hd.txtNgayLap.Text = dt.ToShortDateString();
                    hd.btnShowKH.Enabled = true;
                    hd.btnThemTiep.Hide();
                    hd.setTextBox(_hdService.SinhMaHoaDon(), FormLogin.ma, "", DateTime.Now.ToShortDateString());
                    hd.btnThemTiep.Text = "Tiếp tục";
                    hd.ShowDialog(this);
                }
            }

            if (lblHienHanh.Text == PHIEUNHAP)
            {
                if (!pn.Visible)
                {
                    //hd.clearText();
                    pn.txtNgayLap.Text = DateTime.Now.ToShortDateString();
                    pn.btnShowNCC.Enabled = true;
                    pn.btnTiepTuc.Hide();
                    //hd.setTextBox(_hdService.SinhMaHoaDon(), FormLogin.ma, "", DateTime.Now.ToShortDateString());
                    pn.btnTiepTuc.Text = "Tiếp tục";
                    pn.ShowDialog(this);
                }
            }
        }

        //Cần code mở ra xem
        private void itemSua_Click(object sender, EventArgs e)
        {
            if (lblHienHanh.Text == NHANVIEN)
            {
                if (!nvEdit.Visible)
                {
                    nvEdit.setTextToTextBox(getNhanVien());
                    nvEdit.ShowDialog();
                }
            }

            if (lblHienHanh.Text == HANGHOA)
            {
                if (!hhEdit.Visible)
                {
                    hhEdit.setTextToTextBox(getHangHoa());
                    hhEdit.ShowDialog();
                }
            }

            if (lblHienHanh.Text == KHACHHANG)
            {
                if (!khEdit.Visible)
                {
                    khEdit.setTextToTextBox(getKhachHang());
                    khEdit.ShowDialog();
                }
            }

            if (lblHienHanh.Text == NHACUNGCAP)
            {
                if (!nccEdit.Visible)
                {
                    nccEdit.setTextToTextBox(getNhaCungCap());
                    nccEdit.ShowDialog();
                }
            }

            if (lblHienHanh.Text == HOADON)
            {
                if (!hdEdit.Visible)
                {
                    hdEdit.setTextToTextBox(getHoaDon());
                    hdEdit.ShowDialog();
                }
            }

            if (lblHienHanh.Text == PHIEUNHAP)
            {
                //Đây code đi em
            }
        }

        //Cần code mở ra xem
        private void itemXoa_Click(object sender, EventArgs e)
        {
            if (ViewDelete())
            {
                if (lblHienHanh.Text == NHANVIEN)
                {
                    if (_nvService.XoaNhanVien(dataGridView.CurrentRow.Cells[0].Value.ToString()))
                    {
                        dataGridView.DataSource = _nvService.DanhSachNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Nhân viên này không xóa được do có phụ trách ghi phiếu.", "Thông báo lỗi");
                    }
                }

                if (lblHienHanh.Text == HANGHOA)
                {

                    if (_spService.XoaSanPham(dataGridView.CurrentRow.Cells[0].Value.ToString()))
                    {
                        dataGridView.DataSource = _spService.DanhSachSanPham();
                    }
                    else
                    {
                        MessageBox.Show("Hàng này không xóa được do đã được ghi phiếu.", "Thông báo lỗi");
                    }
                }

                if (lblHienHanh.Text == KHACHHANG)
                {
                    if (_khService.XoaKhachHang(dataGridView.CurrentRow.Cells[0].Value.ToString()))
                    {
                        dataGridView.DataSource = _khService.DanhSachKhachHang();
                    }
                    else
                    {
                        MessageBox.Show("Khách hàng này không xóa được do có lịch sử giao dịch.", "Thông báo lỗi");
                    }
                }

                if (lblHienHanh.Text == NHACUNGCAP)
                {
                    if (_nccService.XoaNhaCungCap(dataGridView.CurrentRow.Cells[0].Value.ToString()))
                    {
                        dataGridView.DataSource = _nccService.DanhSachNhaCungCap();
                    }
                    else
                    {
                        MessageBox.Show("Công ty này không xóa được do có lịch sử giao dịch.", "Thông báo lỗi");
                    }
                }

                if (lblHienHanh.Text == HOADON)
                {
                    if (_hdService.XoaHoaDon(dataGridView2.CurrentRow.Cells[0].Value.ToString()))
                    {
                        dataGridView2.DataSource = _hdService.DanhSachHoaDon();
                    }
                    else
                    {
                        MessageBox.Show("Hóa đơn này không xóa được do đã được giao dịch.", "Thông báo lỗi");
                    }
                }

                if (lblHienHanh.Text == PHIEUNHAP)
                {
                    if (_pnService.XoaPhieuNhap(dataGridView2.CurrentRow.Cells[0].Value.ToString()))
                    {
                        dataGridView2.DataSource = _pnService.DanhSachPhieuNhap();
                    }
                    else
                    {
                        MessageBox.Show("Phiếu nhập này không xóa được do đã được giao dịch.", "Thông báo lỗi");
                    }
                }
            }
        }

        //Hàm kiểm tra và một số hàm truyền nhận data qua lại với nhau
        //Hàm bổ sung không cần xem
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.txbPassword.Clear();
            login.Show();
            nv.Close();
            pn.Close();
            hd.Close();
            kh.Close();
            hh.Close();
            ncc.Close();
        }

        private void dataGridView2_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    DataGridView grid = sender as DataGridView;
                    grid.CurrentCell = grid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    Point pt = grid.PointToClient(Control.MousePosition);
                    ctm.Show(dataGridView, pt.X, pt.Y);
                }
                catch { }
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            login.txbPassword.Clear();
            login.Show();
        }

        private void lblHienHanh_TextChanged(object sender, EventArgs e)
        {
            if (lblHienHanh.Text == HOADON || lblHienHanh.Text == PHIEUNHAP)
            {
                panelDetail.Visible = true;
                btnTick.Enabled = true;
                btnThongKe.Show();
            }
            else
            {
                panelDetail.Visible = false;
                btnTick.Enabled = false;
                btnThongKe.Hide();
            }
        }

        private void dataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    DataGridView grid = sender as DataGridView;
                    grid.CurrentCell = grid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    Point pt = grid.PointToClient(Control.MousePosition);
                    ctm.Show(dataGridView, pt.X, pt.Y);
                }
                catch
                {
                    //Do nothing
                }
            }
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            try
            {
                String mahd = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                String manv = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                String makh = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                if (lblHienHanh.Text == HOADON)
                    dataGridDetail.DataSource = _hdService.DanhSachCTHoaDon(mahd, manv, makh);
                else if (lblHienHanh.Text == PHIEUNHAP)
                    dataGridDetail.DataSource = _pnService.DanhSachCTPhieuNhap(mahd, manv, makh);
            } catch
            {

            }
        }

        public HangHoa getHangHoa()
        {
            return _spService.TimKiemMotSanPham(dataGridView.CurrentRow.Cells[0].Value.ToString());
        }

        public NhanVien getNhanVien()
        {
            return _nvService.TimKiemMotNhanVien(dataGridView.CurrentRow.Cells[0].Value.ToString());
        }

        public NhaCungCap getNhaCungCap()
        {
            return _nccService.TimKiemMotNhaCungCap(dataGridView.CurrentRow.Cells[0].Value.ToString());
        }

        public KhachHang getKhachHang()
        {
            return _khService.TimKiemMotKhachHang(dataGridView.CurrentRow.Cells[0].Value.ToString());
        }

        public HoaDon getHoaDon()
        {
            return _hdService.TimKiemMotHoaDon(dataGridView2.CurrentRow.Cells[0].Value.ToString());
        }

        public PhieuNhap getPhieuNhap()
        {
            return _pnService.TimKiemMotPhieuNhap(dataGridView2.CurrentRow.Cells[0].Value.ToString());
        }

        private bool ViewDelete()
        {
            string content = string.Format("Bạn chắc chắn muốn xóa ?");
            if (MessageBox.Show(content, "Xác nhận muốn xóa", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        private void dataGridDetail_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    DataGridView grid = sender as DataGridView;
                    grid.CurrentCell = grid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    Point pt = grid.PointToClient(Control.MousePosition);
                    ctmDetail.Show(dataGridDetail, pt.X, pt.Y);
                }
                catch
                {
                    //Do nothing
                }
            }
        }

        private void toolThemCT_Click(object sender, EventArgs e)
        {

            if (lblHienHanh.Text == HOADON)
            {
                KhachHang kh = _khService.TimKiemMotKhachHang(dataGridView2.CurrentRow.Cells[2].Value.ToString());
                String mahd = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                String khach = kh.makh.ToString().Trim() + " - " + kh.tenkh.ToString().Trim();
                String manv = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                String tmpNgay = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                String ngay = tmpNgay.Split(' ')[0];
                hd.setTextBox(mahd, manv, khach, ngay);
                hd.btnShowKH.Enabled = false;
                hd.btnThemTiep.Show();
                hd.btnThemTiep.Text = "Thêm tiếp";
                hd.ShowDialog(this);
            }

            if(lblHienHanh.Text == PHIEUNHAP)
            {

            }
        }

        private void toolSuaCT_Click(object sender, EventArgs e)
        {

        }

        private void toolXoaCT_Click(object sender, EventArgs e)
        {
            if (ViewDelete())
            {
                if (lblHienHanh.Text == HOADON)
                {
                    int id = int.Parse(dataGridDetail.CurrentRow.Cells[0].Value.ToString().Trim());
                    if (_hdService.XoaCTHoaDon(id))
                    {
                        try
                        {
                            String mahd = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                            String manv = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                            String makh = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                            dataGridDetail.DataSource = _hdService.DanhSachCTHoaDon(mahd, manv, makh);
                        }
                        catch
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi, không xóa được !", "Thông báo lỗi");
                    }
                }

                if (lblHienHanh.Text == PHIEUNHAP)
                {
                    int id = int.Parse(dataGridDetail.CurrentRow.Cells[0].Value.ToString().Trim());
                    if (_pnService.XoaCTPhieuNhap(id))
                    {
                        try
                        {
                            String mahd = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                            String manv = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                            String makh = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                            dataGridDetail.DataSource = _pnService.DanhSachCTPhieuNhap(mahd, manv, makh);
                        }
                        catch
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi, không xóa được !", "Thông báo lỗi");
                    }
                }
            }
        }
    }
}
