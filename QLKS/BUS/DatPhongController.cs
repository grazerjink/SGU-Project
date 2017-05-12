using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using DAO;

namespace BUS
{
    public class DatPhongController
    {
        private Databases db = Databases.INSTANCE;

        public IEnumerable danhSachPhieuDat(string trangthai)
        {
            return db.hienThiDanhSach(Option.PHIEUDAT, trangthai);
        }
        public void doiTrangThaiPhieuDat(string maphieu, string trangthai)
        {
            db.thayDoiTrangThai(maphieu, trangthai, Option.PHIEUDAT);
        }
        public bool themPhieuDat(string cmnd, string manv, string sophong, string ngaydenthue, string ngaydi)
        {
            string maphieudat = null;
            string trangthai = Option.P_DA_DAT;
            if (db.soLuong(Option.PHIEUDAT).ToString().Length == 1)
            {
                if (db.soLuong(Option.PHIEUDAT) + 1 == 10)
                    maphieudat = "PD0" + (db.soLuong(Option.PHIEUDAT) + 1);
                else
                    maphieudat = "PD00" + (db.soLuong(Option.PHIEUDAT) + 1);
            }
            else if (db.soLuong(Option.PHIEUDAT).ToString().Length == 2)
            {
                if (db.soLuong(Option.PHIEUDAT) + 1 == 100)
                    maphieudat = "PD" + (db.soLuong(Option.PHIEUDAT) + 1);
                else
                    maphieudat = "PD0" + (db.soLuong(Option.PHIEUDAT) + 1);
            }
            else if (db.soLuong(Option.PHIEUDAT).ToString().Length == 3) maphieudat = "PD" + (db.soLuong(Option.PHIEUDAT) + 1);            
            if (db.them(new phieudat(maphieudat, cmnd, manv, sophong, ngaydenthue, ngaydi, trangthai)))
                return true;
            else
                return false;
        }

        public void huyDatPhongQuaHan()
        {
            db.huyDatPhongQuaHan();
        }
    }
}
