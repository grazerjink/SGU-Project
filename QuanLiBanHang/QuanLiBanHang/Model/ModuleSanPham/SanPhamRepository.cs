using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace QuanLiBanHang.Model
{
    class SanPhamRepository : ISanPhamRepository
    {
        QLBHEntities entities = new QLBHEntities();

        public IEnumerable<HangHoaDTO> dsSanPham()
        {
            return (from h in entities.HangHoas select new HangHoaDTO() { MAHANG = h.mahang, TENHANG = h.tenhang, HANGSX = h.hangsx, SOLUONG = h.soluong, DONGIA = h.dongia }).ToArray();
        }

        public HangHoa layInfo_1SP(String str)
        {
            var q = entities.HangHoas.Where(t => t.mahang.Contains(str));
            return q.FirstOrDefault();
        }

        public IEnumerable<HangHoaDTO> timKiemSP(String str)
        {
            var q = entities.HangHoas.Where(t => t.mahang.Contains(str) || t.tenhang.Contains(str) || t.hangsx.Contains(str));
            return (from h in q select new HangHoaDTO { MAHANG = h.mahang, TENHANG = h.tenhang, HANGSX = h.hangsx, SOLUONG = h.soluong, DONGIA = h.dongia }).ToList();
         }

        public void suaSP(HangHoa sp)
        {
           var update = layInfo_1SP(sp.mahang);
           update.tenhang = sp.tenhang;
           update.hangsx = sp.hangsx;
           update.soluong = sp.soluong;
           update.dongia = sp.dongia;
           entities.SaveChanges();
        }

        public void themSP(HangHoa sp)
        {  
            entities.HangHoas.Add(sp);
            entities.SaveChanges();
        }

        public void xoaSP(String ma)
        {
            var code = layInfo_1SP(ma);
            entities.HangHoas.Remove(code);
            entities.SaveChanges();
        }

        public int soluongSP()
        {
            return entities.HangHoas.Count();
        }

        public void capNhatSLSP(string ma, string table, decimal sl)
        {
            
            if(table.Equals("HOADON"))
            {
                var h = layInfo_1SP(ma);
                h.soluong = h.soluong - sl;
                entities.SaveChanges(); 
            }

            if(table.Equals("PHIEUNHAP"))
            {
                var q = layInfo_1SP(ma);
                q.soluong = q.soluong + sl;
                entities.SaveChanges();
            }
        }
    }
}
