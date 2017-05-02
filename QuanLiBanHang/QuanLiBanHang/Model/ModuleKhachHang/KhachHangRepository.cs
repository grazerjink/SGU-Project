using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLiBanHang.Model
{
    class KhachHangRepository : IKhachHangRepository
    {
        private QLBHEntities entities = new QLBHEntities();

        public IEnumerable<KhachHangDTO> dsKhachHang()
        {
            return (from h in entities.KhachHangs select new KhachHangDTO() { MAKH = h.makh, TENKH = h.tenkh, DIENTHOAI = h.dienthoai, DIACHI = h.diachi, TIEMNANG = h.tiemnang }).ToArray();
        }

        public KhachHang layInfo_1KH(String str)
        {
            var q = entities.KhachHangs.Where(t => t.makh.Contains(str));
            return q.FirstOrDefault();
        }

        public IEnumerable<KhachHangDTO> timKiemKH(String str)
        {
            var q = entities.KhachHangs.Where(t => t.makh.Contains(str) || t.tenkh.Contains(str) || t.diachi.Contains(str) || t.dienthoai.Contains(str));
            return (from h in q select new KhachHangDTO { MAKH = h.makh, TENKH = h.tenkh, DIENTHOAI = h.dienthoai, DIACHI = h.diachi, TIEMNANG = h.tiemnang }).ToList();
         }

        public void suaKH(KhachHang kh)
        {
            var update = entities.KhachHangs.Where(s => s.makh == kh.makh).FirstOrDefault();
            update.tenkh = kh.tenkh;
            update.diachi = kh.diachi;
            update.dienthoai = kh.dienthoai;
            update.tiemnang = kh.tiemnang;
            entities.SaveChanges();
        }

        public void themKH(KhachHang kh)
        {
            entities.KhachHangs.Add(kh);
            entities.SaveChanges();
        }

        public void xoaKH(String ma)
        {
            var code = layInfo_1KH(ma);
            entities.KhachHangs.Remove(code);
            entities.SaveChanges();
        }

        public int soluongKH()
        {
            return entities.KhachHangs.Count();
        }
    }
}
