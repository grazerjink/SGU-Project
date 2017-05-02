using DAO;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDonController
    {
        private Databases db = Databases.INSTANCE;

        public IEnumerable thongKeThang(int thang, int nam)
        {
            return db.layThongTinThang(thang, nam);
        }
        public IEnumerable thongKeNam(int nam)
        {
            return db.layThongTinNam(nam);
        }
        public IEnumerable thongKeQuy(string quy, int nam)
        {
            return db.layThongTinQuy(quy,nam);
        }
        public hoadon layThongTinHoaDon(string mahd)
        {
            var q = db.layHoaDon(mahd);
            if (q != null)
            {
                return (hoadon)q ;
            }
            else
            {
                return null;
            }
        }
    }
}
