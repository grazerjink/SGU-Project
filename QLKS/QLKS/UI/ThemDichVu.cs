using BUS;
using DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;

namespace QLKS.UI
{
    public partial class ThemDichVu : Form
    {
        private DanhSach ds;
        private string maphieuthue;
        private string phong;
        private DichVuController dv;

        public ThemDichVu(DanhSach ds, string maphieuthue, string phong)
        {
            InitializeComponent();
            this.phong = phong;
            this.maphieuthue = maphieuthue;
            this.ds = ds;

            dv = new DichVuController();
            txtMaPhieuThue.Text = maphieuthue;
            txtPhong.Text = phong;
            hienThiDanhSachDV();
            hienThiDichVuDaChon();
        }

        public void hienThiDanhSachDV()
        {
            IEnumerable list = dv.danhSachDichVu();
            foreach (object o in list) {
                listDichVu.Items.Add(((dichvu)o).tendichvu);
            }
        }
        public void hienThiDichVuDaChon()
        {
            tblSuDungDichVu.RowCount = 1;
            foreach(Object item in dv.danhSachDaThem(maphieuthue))
            {
                int stt = ((sudungdichvu)item).stt;
                string tendv = ((sudungdichvu)item).tendichvu;
                string dongia = dv.layGiaDichVu(tendv);
                string soluong = ((sudungdichvu)item).soluong;
                tblSuDungDichVu.Rows.Add(stt, tendv, dongia, soluong);
            }
        }
        private void chonDichVu(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtSoLuong.Text.Trim(), @"^[0-9]+$") && listDichVu.SelectedIndex != -1 && !txtSoLuong.Text.Equals("0"))
            {
                string tendichvu = listDichVu.SelectedItem.ToString();
                string soluong = txtSoLuong.Text.Trim();
                string dongia = dv.layGiaDichVu(listDichVu.SelectedItem.ToString()).Trim();
                string tongtien = (int.Parse(soluong) * int.Parse(dongia)).ToString().Trim();
                //listDV.Add(new sudungdichvu(maphieuthue, tendichvu, soluong, tongtien));
                //tblSuDungDichVu.Rows.Add(tendichvu, dongia,soluong);
                dv.themDichVu(maphieuthue, tendichvu, soluong, tongtien);
                hienThiDichVuDaChon();
                txtSoLuong.Text = null;
                listDichVu.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Chưa chọn dịch vụ hoặc chưa nhập số lượng");
            }
        }
        private void xacNhan(object sender, EventArgs e)
        {
            this.Close();
        }
        private void thoatChucNang(object sender, FormClosedEventArgs e)
        {
            ds.Enabled = true;
        }
        private void xoaDichVu(object sender, EventArgs e)
        {
            try
            {
                int stt = int.Parse(tblSuDungDichVu.CurrentRow.Cells[0].Value.ToString());
                Console.WriteLine("STT2: " + stt);
                if (!dv.xoaDichVu(stt))
                {
                    MessageBox.Show("Xóa dịch vụ thất bại, thực hiện lại...");
                }
                hienThiDichVuDaChon();
            }
            catch
            {

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
    }
}
