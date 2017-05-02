using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using DAO;

namespace BUS
{
    public class ThuePhongController
    {
        private Databases db = Databases.INSTANCE;

        public IEnumerable danhSachPhieuThue(string trangthai)
        {
            return db.hienThiDanhSach(Option.PHIEUTHUE, trangthai);
        }
        public void doiTrangThaiPhieuThue(string maphieu, string trangthai)
        {
            db.thayDoiTrangThai(maphieu, trangthai, Option.PHIEUTHUE);
        }
        public phieuthue layThongTinPhieuThue(string maphieu)
        {
            return db.layPhieuThue(maphieu);
        }
        public bool themPhieuThue(string cmnd, string manv, string sophong, string ngaythue, string ngaydi)
        {
            string maphieuthue = null;
            string trangthai = Option.P_DANG_THUE;
            if (db.soLuong(Option.PHIEUTHUE).ToString().Length == 1)
            {
                if (db.soLuong(Option.PHIEUTHUE) + 1 == 10)
                    maphieuthue = "PT0" + (db.soLuong(Option.PHIEUTHUE) + 1);
                else
                    maphieuthue = "PT00" + (db.soLuong(Option.PHIEUTHUE) + 1);
            }
            if (db.soLuong(Option.PHIEUTHUE).ToString().Length == 2)
            {
                if (db.soLuong(Option.PHIEUTHUE) + 1 == 100)
                    maphieuthue = "PT" + (db.soLuong(Option.PHIEUTHUE) + 1);
                else
                    maphieuthue = "PT0" + (db.soLuong(Option.PHIEUTHUE) + 1);
            }
            if (db.soLuong(Option.PHIEUTHUE).ToString().Length == 3) maphieuthue = "PT" + (db.soLuong(Option.PHIEUTHUE) + 1);
            if (db.them(new phieuthue(maphieuthue, cmnd, manv, sophong, ngaythue, ngaydi, trangthai)))
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
