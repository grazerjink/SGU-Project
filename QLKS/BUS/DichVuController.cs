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

        public bool themDanhSachDichVu(List<sudungdichvu> list)
        {
            if(db.themDichVu(list))
            {
                return true;
            } else
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
