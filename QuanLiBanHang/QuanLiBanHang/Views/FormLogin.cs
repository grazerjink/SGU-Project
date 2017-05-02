using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using QuanLiBanHang.Model;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiBanHang
{

    public partial class FormLogin : Form
    {
        QLBHEntities entities = new QLBHEntities();
        public static String ma = null;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = txbUsername.Text;
            String password = txbPassword.Text;
            var acc = (from u in entities.TaiKhoans
                       where u.taikhoan1 == username && u.matkhau == password
                       select u);
            if (username == "" || password == "")
            {
                MessageBox.Show("Chưa nhập tài khoản hoặc mật khẩu...?");
            }
            else
            {
                if (acc != null)
                {
                    try
                    {
                        MessageBox.Show(acc.First().NhanVien.tennv + " đã đăng nhâp thành công.");
                        this.Hide();
                        ma = acc.FirstOrDefault().manv.ToString();
                        new FormMain(this).Show();
                    } catch (InvalidOperationException ex)
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng.");
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng.");
                }
            }
        }
    }
}
