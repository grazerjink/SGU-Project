using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TaiKhoanController
    {
        private Databases db = Databases.INSTANCE;

        public string kiemTraTaiKhoan(string taikhoan, string matkhau)
        {
            return db.kiemTraTaiKhoan(taikhoan, matkhau);
        }
        public string layMaNhanVien(string taikhoan)
        {
            return db.layMaNV(taikhoan);
        }
        public bool kiemTraMatKhauCu(string mkcu, string manv)
        {
            if (db.kiemTraMatKhauCu(mkcu, manv))
                return true;
            else
                return false;
        }
        public bool capNhatMatKhauMoi(string mkmoi, string manv)
        {
            if (db.capNhatMatKhauMoi(mkmoi, manv))
                return true;
            else
                return false;
        }
        public string kiemTraThongTinDangKy(string thongtin)
        {
            return db.kiemTraThongTin(thongtin);
        }
    }
}
