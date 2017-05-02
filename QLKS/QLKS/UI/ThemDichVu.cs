using BUS;
using DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QLKS.UI
{
    public partial class ThemDichVu : Form
    {
        private DanhSach ds;
        private string maphieuthue;
        private string phong;
        private DichVuController dv;
        List<sudungdichvu> listDV;

        public ThemDichVu(DanhSach ds, string maphieuthue, string phong)
        {
            InitializeComponent();
            this.phong = phong;
            this.maphieuthue = maphieuthue;
            this.ds = ds;

            dv = new DichVuController();
            listDV = new List<sudungdichvu>();
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
            IEnumerable dsdv = dv.danhSachDaThem(maphieuthue);
            foreach(Object item in dsdv)
            {
                string tendv = ((sudungdichvu)item).tendichvu;
                string dongia = dv.layGiaDichVu(tendv);
                string soluong = ((sudungdichvu)item).soluong;
                tblSuDungDichVu.Rows.Add(tendv, dongia, soluong);
            }
        }

        private void chonDichVu(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtSoLuong.Text.Trim(), @"^[1-9]+$") && listDichVu.SelectedIndex != -1)
            {
                string tendichvu = listDichVu.SelectedItem.ToString();
                string soluong = txtSoLuong.Text.Trim();
                string dongia = dv.layGiaDichVu(listDichVu.SelectedItem.ToString()).Trim();
                string tongtien = (int.Parse(soluong) * int.Parse(dongia)).ToString().Trim();
                listDV.Add(new sudungdichvu(maphieuthue, tendichvu, soluong, tongtien));
                tblSuDungDichVu.Rows.Add(tendichvu, dongia,soluong);
                txtSoLuong.Text = null;
                listDichVu.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Chưa chọn dịch vụ hoặc chưa nhập số lượng");
            }
        }

        private void themDichVu(object sender, EventArgs e)
        {
            if (listDV.Count > 0)
            {
                if (dv.themDanhSachDichVu(listDV))
                {
                    MessageBox.Show("Đã thêm thành công.", "Thông báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi, vui lòng kiếm tra lại", "Thông báo");
                }
            }
            else
            {
                this.Close();
            }
        }

        private void thoatChucNang(object sender, FormClosedEventArgs e)
        {
            ds.Enabled = true;
        }
    }
}
