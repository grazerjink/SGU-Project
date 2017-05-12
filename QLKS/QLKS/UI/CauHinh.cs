using BUS;
using DAO;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLKS.UI
{
    public partial class CauHinh : Form
    {
        private DangNhap dn;
        private string manv;
        private PhongController p;

        public CauHinh(DangNhap dn, string manv)
        {
            InitializeComponent();
            this.dn = dn;
            this.manv = manv;

            p = new PhongController();

            hienThiDanhSach();
            cboLoaiPhong.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 0;
            cboSuaLoaiPhong.SelectedIndex = 0;
            cboSuaTrangThai.SelectedIndex = 0;
            pnlSua.Visible = false;
        }

        public void hienThiDanhSach()
        {
            tblPhong.DataSource = p.danhSachPhong(Option.TYPE_PHONG);
        }

        private void thoatCauHinh(object sender, FormClosedEventArgs e)
        {
            dn.clearTaiKhoanMatKhau();
            dn.Show();
        }

        private void chonLoaiPhong(object sender, System.EventArgs e)
        {
            if (cboLoaiPhong.SelectedIndex == 0)
            {
                txtTienPhong.Text = "100000";
            }
            if (cboLoaiPhong.SelectedIndex == 1)
            {
                txtTienPhong.Text = "150000";
            }
            if (cboLoaiPhong.SelectedIndex == 2)
            {
                txtTienPhong.Text = "200000";
            }
            if (cboLoaiPhong.SelectedIndex == 3)
            {
                txtTienPhong.Text = "250000";
            }
        }

        private void chonSuaLoaiPhong(object sender, System.EventArgs e)
        {
            if (cboSuaLoaiPhong.SelectedIndex == 0)
            {
                txtSuaTienPhong.Text = "100000";
            }
            if (cboSuaLoaiPhong.SelectedIndex == 1)
            {
                txtSuaTienPhong.Text = "150000";
            }
            if (cboSuaLoaiPhong.SelectedIndex == 2)
            {
                txtSuaTienPhong.Text = "200000";
            }
            if (cboSuaLoaiPhong.SelectedIndex == 3)
            {
                txtSuaTienPhong.Text = "250000";
            }
        }

        private void themPhongMoi(object sender, System.EventArgs e)
        {
            string sophong = txtPhong.Text;
            string loaiphong = cboLoaiPhong.SelectedItem.ToString();
            string tienphong = txtTienPhong.Text;
            string trangthai = cboTrangThai.SelectedItem.ToString();
            if (Regex.IsMatch(sophong, @"^(?!000)[0-9]{3}$"))
            {
                errorPhong.Clear();
                //kiem tra du lieu dau vao
                if (p.kiemTraPhong(sophong))
                {
                    p.themPhong(sophong, loaiphong, tienphong, trangthai);
                    errorPhong.Clear();
                    MessageBox.Show("Thêm thành công.", "Thông báo");
                    hienThiDanhSach();
                    txtPhong.Text = null;
                    cboLoaiPhong.SelectedIndex = 0;
                    cboTrangThai.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Phòng đã tồn tại, vui lòng kiểm tra lại.", "Thông báo");
                }
            } else
            {
                errorPhong.SetError(txtPhong, "Phòng nhập không đúng quy tắc số phòng từ 101 - 999");
            }
        }

        private void chonTuyChon(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    DataGridView grid = sender as DataGridView;
                    grid.CurrentCell = grid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    Point pt = grid.PointToClient(Control.MousePosition);
                    ctmTuyChon.Show(grid, pt.X, pt.Y);
                }
                catch { }
            }
        }

        private void chonChucNangSuaPhong(object sender, System.EventArgs e)
        {
            txtSuaPhong.Text = tblPhong.CurrentRow.Cells[1].Value.ToString().Trim();
            string loaiphong = tblPhong.CurrentRow.Cells[2].Value.ToString().Trim();
            string trangthai = tblPhong.CurrentRow.Cells[4].Value.ToString().TrimEnd();
            if (loaiphong.Equals("Đơn"))
                cboSuaLoaiPhong.SelectedIndex = 0;
            else if (loaiphong.Equals("Đôi"))
                cboSuaLoaiPhong.SelectedIndex = 1;
            else if (loaiphong.Equals("Ba"))
                cboSuaLoaiPhong.SelectedIndex = 2;
            else if (loaiphong.Equals("Bốn"))
                cboSuaLoaiPhong.SelectedIndex = 3;

            if (trangthai.Equals("Sẵn sàng"))
                cboSuaTrangThai.SelectedIndex = 0;
            else if (trangthai.Equals("Đang bảo trì"))
                cboSuaTrangThai.SelectedIndex = 1;

            pnlSua.Visible = true;

        }

        private void chonChucNangXoaPhong(object sender, System.EventArgs e)
        {
            string sophong = tblPhong.CurrentRow.Cells[1].Value.ToString().Trim();
            //kiem tra du lieu dau vao
            if (p.xoaPhong(sophong))
            {
                errorPhong.Clear();
                MessageBox.Show("Xóa phòng thành công !", "Thông báo !");
                hienThiDanhSach();
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi, vui lòng kiểm tra lại.", "Thông báo !");
            }
        }

        private void suaPhong(object sender, System.EventArgs e)
        {
            string sophong = txtSuaPhong.Text;
            string loaiphong = cboSuaLoaiPhong.SelectedItem.ToString();
            string tienphong = txtSuaTienPhong.Text;
            string trangthai = cboSuaTrangThai.SelectedItem.ToString();
            if (Regex.IsMatch(sophong, @"^(?!000)[0-9]{3}$"))
            {
                errorPhong.Clear();
                if (p.capNhatPhong(sophong, loaiphong, tienphong, trangthai))
                {
                    pnlSua.Visible = false;
                    MessageBox.Show("Đã cập nhật thành công.", "Thông báo");
                    hienThiDanhSach();
                }
                else
                    MessageBox.Show("Xảy ra lỗi, vui lòng kiểm tra lại.", "Thông báo");
            }
            else
            {
                errorPhong.SetError(txtPhong, "Phòng nhập không đúng quy tắc (hợp lệ khi: 3 chữ số phải khác 0)");
            }

        }

        private void thoatSuaPhong(object sender, System.EventArgs e)
        {
            pnlSua.Visible = false;
        }

        private void hienThiMauTrangThai(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < tblPhong.RowCount; i++)
            {
                if (tblPhong.Rows[i].Cells[4].Value.ToString().Contains("Sẵn sàng"))
                {
                    tblPhong.Rows[i].DefaultCellStyle.BackColor = Color.SpringGreen;
                }
                else if (tblPhong.Rows[i].Cells[4].Value.ToString().Contains("Đang bảo trì"))
                {
                    tblPhong.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }

        private void doiMatKhau(object sender, System.EventArgs e)
        {
            new DoiMatKhau(this, manv).Show();
            this.Enabled = false;
        }
    }
}
