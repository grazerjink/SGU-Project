using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLiBanHang.Model
{
    class NhanVienRepository : INhanVienRepository
    {
        private QLBHEntities entities = new QLBHEntities();

        public IEnumerable<NhanVienDTO> dsNhanVien()
        {
            return (from h in entities.NhanViens select new NhanVienDTO() { MANV = h.manv, TENNV = h.tennv, NGAYSINH = h.ngaysinh, DIENTHOAI = h.dienthoai, DIACHI = h.diachi, CHUCVU = h.chucvu }).ToArray();
        }

        public NhanVien layInfo_1NV(String str)
        {
            var q = entities.NhanViens.Where(t => t.manv.Contains(str));
            return q.FirstOrDefault();
        }

        public IEnumerable<NhanVienDTO> timKiemNV(String str)
        {
            var q = entities.NhanViens.Where(t => t.manv.Contains(str) || t.tennv.Contains(str) || t.ngaysinh.Year.ToString().Contains(str) || t.dienthoai.Contains(str) || t.diachi.Contains(str) || t.chucvu.ToString().Contains(str));
            return (from h in q select new NhanVienDTO { MANV = h.manv, TENNV = h.tennv, NGAYSINH = h.ngaysinh, DIENTHOAI = h.dienthoai, DIACHI = h.diachi, CHUCVU = h.chucvu }).ToList();
         }

        public void suaNV(NhanVien nv)
        {
            var update = entities.NhanViens.Where(s => s.manv == nv.manv).FirstOrDefault();
            update.tennv = nv.tennv;
            update.diachi = nv.diachi;
            update.chucvu = nv.chucvu;
            update.dienthoai = nv.dienthoai;
            update.ngaysinh = nv.ngaysinh;
            entities.SaveChanges();
        }

        public void themNV(NhanVien nv)
        {
            entities.NhanViens.Add(nv);
            entities.SaveChanges();
        }

        public void xoaNV(String ma)
        {
            var code = layInfo_1NV(ma);
            var taikhoan = entities.TaiKhoans.Where(t => t.manv == ma).FirstOrDefault();
            entities.NhanViens.Remove(code);
            entities.TaiKhoans.Remove(taikhoan);
            entities.SaveChanges();
        }

        public int soluongNV()
        {
            return entities.NhanViens.Count();
        }

        public void themTaiKhoan(TaiKhoan tk)
        {
            entities.TaiKhoans.Add(tk);
            entities.SaveChanges();
        }
    }
}
