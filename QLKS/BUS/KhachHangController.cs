using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhachHangController
    {
        private Databases db = Databases.INSTANCE;

        public string kiemTraKhachHang(string cmnd)
        {
            return db.kiemTraKhachHang(cmnd);
        }
        public bool themKhachHang(string cmnd, string hoten, string dienthoai)
        {
            if (kiemTraKhachHang(cmnd) == null)
            {
                if (db.them(new khachhang(cmnd, hoten, dienthoai)))
                    return true;
                else
                    return false;
            }
            else
                return true;
        }
    }
}
