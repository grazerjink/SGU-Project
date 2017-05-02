using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace QLKS.UI
{
    public partial class TinhTrang : UserControl
    {
        private TextBox txtPhong;
        private PhongController p;

        public TinhTrang(TextBox txtPhong)
        {
            InitializeComponent();
            p = new PhongController();
            hienThiDanhSachPhong();
            this.txtPhong = txtPhong;
            
        }

        public void hienThiDanhSachPhong()
        {
            //Show lên danh sách tình trạng phòng
            tblTinhTrang.DataSource = p.danhSachPhong(null);
        }
        private void chonPhong(object sender, MouseEventArgs e)
        {
            txtPhong.Text = tblTinhTrang.CurrentRow.Cells[1].Value.ToString().Trim();
        }
        private void hienThiTrangThaiMau(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < tblTinhTrang.RowCount; i++)
            {
                if (tblTinhTrang.Rows[i].Cells[4].Value.ToString().Contains("Sẵn sàng"))
                {
                    tblTinhTrang.Rows[i].DefaultCellStyle.BackColor = Color.SpringGreen;
                }
                else if (tblTinhTrang.Rows[i].Cells[4].Value.ToString().Contains("Đã đặt"))
                {
                    tblTinhTrang.Rows[i].DefaultCellStyle.BackColor = Color.Wheat;
                }
                else if (tblTinhTrang.Rows[i].Cells[4].Value.ToString().Contains("Đang thuê"))
                {
                    tblTinhTrang.Rows[i].DefaultCellStyle.BackColor = Color.OrangeRed;
                }
            }
        }
    }
}
