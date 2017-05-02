using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TraPhongController
    {
        private Databases db = Databases.INSTANCE;

        public bool themHoaDon(string manv, string maphieuthue, string tongngaythue, string tongtienphong, string tongtiendichvu, string ngaythanhtoan)
        {
            string mahoadon = null;
            if (db.soLuong(Option.HOADON).ToString().Length == 1)
            {
                if (db.soLuong(Option.HOADON) + 1 == 10)
                    mahoadon = "HD0" + (db.soLuong(Option.HOADON) + 1);
                else
                    mahoadon = "HD00" + (db.soLuong(Option.HOADON) + 1);
            }
            if (db.soLuong(Option.HOADON).ToString().Length == 2)
            {
                if (db.soLuong(Option.HOADON) + 1 == 100)
                    mahoadon = "HD" + (db.soLuong(Option.HOADON) + 1);
                else
                    mahoadon = "HD0" + (db.soLuong(Option.HOADON) + 1);
            }
            if (db.soLuong(Option.HOADON).ToString().Length == 3) mahoadon = "HD" + (db.soLuong(Option.HOADON) + 1);
            if (db.them(new hoadon(mahoadon, manv, maphieuthue, tongngaythue, tongtienphong, tongtiendichvu, ngaythanhtoan)))
                return true;
            else
                return false;

        }
    }
}
