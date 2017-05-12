using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using DAO;

namespace BUS
{
    public class PhongController
    {
        private Databases db = Databases.INSTANCE;

        public IEnumerable danhSachPhong(string trangthai)
        {
            return db.hienThiDanhSach(Option.PHONG, trangthai);
        }
        public void doiTrangThaiPhong(string sophong, string trangthai)
        {
            db.thayDoiTrangThai(sophong, trangthai, Option.PHONG);
        }
        public bool capNhatPhong(string phong, string loai, string gia, string trangthai)
        {
            try
            {
                db.suaPhong(phong, loai, gia, trangthai);
                return true;
            }
            catch { return false; }
        }
        public bool themPhong(string phong, string loaiphong, string tienphong, string trangthai)
        {
            if (db.them(new phong(phong, loaiphong, tienphong, trangthai)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool xoaPhong(string phong)
        {
            try
            {
                db.xoa(new phong(phong));
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool kiemTraPhong(string phong)
        {
            if(db.kiemTraPhong(phong))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
