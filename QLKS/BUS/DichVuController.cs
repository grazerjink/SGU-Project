using DAO;
using System.Collections;
using System.Collections.Generic;

namespace BUS
{
    public class DichVuController
    {
        private Databases db = Databases.INSTANCE;

        public IEnumerable danhSachDichVu()
        {
            return db.hienThiDanhSach(Option.DICHVU,null);
        }
        public IEnumerable danhSachDaThem(string maphieuthue)
        {
            return db.hienThiDanhSach(Option.SUDUNGDICHVU, maphieuthue);
        }
        public bool themDichVu(string maphieuthue, string tendichvu, string soluong, string tongtien)
        {
            if(db.them(new sudungdichvu(maphieuthue, tendichvu, soluong, tongtien)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool xoaDichVu(int stt)
        {
            if (db.xoa(new sudungdichvu(stt)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string layGiaDichVu(string tendv)
        {
            return db.layGiaTienDichVu(tendv);
        }
    }
}
