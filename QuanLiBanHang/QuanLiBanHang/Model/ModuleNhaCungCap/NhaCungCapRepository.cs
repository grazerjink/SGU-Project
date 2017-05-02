using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLiBanHang.Model
{
    class NhaCungCapRepository : INhaCungCapRepository
    {
        private QLBHEntities entities = new QLBHEntities();

        public IEnumerable<NhaCungCapDTO> dsNhaCungCap()
        {
            return (from h in entities.NhaCungCaps select new NhaCungCapDTO() { MANCC = h.mancc, TENNCC = h.tenncc, DIENTHOAI = h.sdt, EMAIL = h.email, DIACHI = h.diachi }).ToArray();
        }

        public NhaCungCap layInfo_1NCC(String str)
        {
            var q = entities.NhaCungCaps.Where(t => t.mancc.Contains(str));
            return q.FirstOrDefault();
        }

        public IEnumerable<NhaCungCapDTO> timKiemNCC(String str)
        {
            var q = entities.NhaCungCaps.Where(t => t.mancc.Contains(str) || t.tenncc.Contains(str) || t.sdt.Contains(str) || t.diachi.Contains(str) || t.email.Contains(str));
            return (from h in q select new NhaCungCapDTO() { MANCC = h.mancc, TENNCC = h.tenncc, DIENTHOAI = h.sdt, EMAIL = h.email, DIACHI = h.diachi }).ToList();
         }

        public void suaNCC(NhaCungCap ncc)
        {
            var update = entities.NhaCungCaps.Where(s => s.mancc == ncc.mancc).FirstOrDefault();
            update.tenncc = ncc.tenncc;
            update.diachi = ncc.diachi;
            update.email = ncc.email;
            update.sdt = ncc.sdt;
            entities.SaveChanges();
        }

        public void themNCC(NhaCungCap ncc)
        {
            entities.NhaCungCaps.Add(ncc);
            entities.SaveChanges();
        }

        public void xoaNCC(String ma)
        {
            var code = layInfo_1NCC(ma);
            entities.NhaCungCaps.Remove(code);
            entities.SaveChanges();
        }

        public int soluongNCC()
        {
            return entities.NhaCungCaps.Count();
        }
    }
}
