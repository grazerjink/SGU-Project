using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiBanHang.Model;

namespace QuanLiBanHang.Model
{
    class PhieuNhapRepository : IPhieuNhapRepository
    {
        private QLBHEntities entities = new QLBHEntities();

        public IEnumerable<PhieuNhapDTO> dsPhieuNhap()
        {
            return (from h in entities.PhieuNhaps select new PhieuNhapDTO() { MAPN = h.mapn, MANV = h.manv, MANCC = h.mancc, NGAYNHAP = h.ngaynhap, TONGTIEN = h.tongtien}).ToArray();
        }

        public IEnumerable<ctPhieuNhapDTO> dsCTPhieuNhap (String mahd, String manv, String mancc)
        {
            return (    from d in entities.Ct_PhieuNhap
                        //join nv in entities.NhanViens on manv equals nv.manv
                        //join hh in entities.HangHoas on d.mahang equals hh.mahang
                        //join kh in entities.NhaCungCaps on mancc equals kh.mancc
                        where d.mapn == mahd
                        select new ctPhieuNhapDTO() {STT = d.id, TENNV = d.PhieuNhap.NhanVien.tennv, TENNCC = d.PhieuNhap.NhaCungCap.tenncc, MAHANG = d.mahang, TENHANG = d.HangHoa.tenhang, SOLUONG = d.soluong, GIANHAP = d.gianhap }).ToList();
        }

        public PhieuNhap layInfo_1PN(String str)
        {
            var q = entities.PhieuNhaps.Where(t => t.mapn.Contains(str));
            return q.FirstOrDefault();
        }

        public IEnumerable<PhieuNhapDTO> timKiemPN(String str)
        {
            var q = entities.PhieuNhaps.Where(t => t.mapn.Contains(str) || t.mancc.Contains(str) || t.manv.Contains(str) || t.ngaynhap.ToShortDateString().Contains(str) || t.tongtien.ToString() == str);
            return (from h in q select new PhieuNhapDTO { MAPN = h.mapn, MANV = h.manv, MANCC = h.mancc, NGAYNHAP = h.ngaynhap, TONGTIEN = h.tongtien }).ToList();
         }

        public void suaPN(PhieuNhap pn)
        {
            var q = layInfo_1PN(pn.mapn);
            q.mancc = pn.mancc;
            q.tongtien = pn.tongtien;
            entities.SaveChanges();
        }

        public void themPN(PhieuNhap pn)
        {
            entities.PhieuNhaps.Add(pn);
            entities.SaveChanges();
        }

        public void xoaPN(String ma)
        {
            var code = layInfo_1PN(ma);
            entities.PhieuNhaps.Remove(code);
            entities.SaveChanges();
        }

        public IEnumerable<HangHoaDTO_HD> dsSanPham()
        {
            return (from h in entities.HangHoas select new HangHoaDTO_HD { MAHANG = h.mahang, TENHANG = h.tenhang, SOLUONG = h.soluong, DONGIA = h.dongia }).ToList();
        }

        public IEnumerable<NhaCungCapDTO_HD> dsNCC()
        {
            return (from h in entities.NhaCungCaps select new NhaCungCapDTO_HD { MANCC = h.mancc, TENNCC = h.tenncc, EMAIL = h.email, DIENTHOAI = h.sdt }).ToList();
        }

        public IEnumerable<HangHoaDTO_HD> timKiemSP(string str)
        {
            var q = entities.HangHoas.Where(t => t.mahang.Contains(str) || t.tenhang.Contains(str) || t.hangsx.Contains(str));
            return (from h in q select new HangHoaDTO_HD { MAHANG = h.mahang, TENHANG = h.tenhang, SOLUONG = h.soluong, DONGIA = h.dongia }).ToList();
        }

        public IEnumerable<NhaCungCapDTO_HD> timKiemNCC(string str)
        {
            var q = entities.NhaCungCaps.Where(t => t.mancc.Contains(str) || t.tenncc.Contains(str) || t.email.Contains(str) || t.sdt.Contains(str));
            return (from h in q select new NhaCungCapDTO_HD { MANCC = h.mancc, TENNCC = h.tenncc, EMAIL = h.email, DIENTHOAI = h.sdt }).ToList();
        }

        public Ct_PhieuNhap layInfo_1CTPN(int id)
        {
            var q = entities.Ct_PhieuNhap.Where(t => t.id == id);
            return q.FirstOrDefault();
        }

        public IEnumerable<Ct_PhieuNhap> layInfo_CTPN(string ma)
        {
            throw new NotImplementedException();
            //
        }

        public void themCTPN(Ct_PhieuNhap ctPN)
        {
            entities.Ct_PhieuNhap.Add(ctPN);
            entities.SaveChanges();
        }

        public void suaCTPN(Ct_PhieuNhap ctPN)
        {
            throw new NotImplementedException();
            //Chưa nghĩ ra
        }

        public void xoaCTPN(int id)
        {
            var code = layInfo_1CTPN(id);
            entities.Ct_PhieuNhap.Remove(code);
            entities.SaveChanges();
        }

        public void xoaSachCTPN(string maPN)
        {
            throw new NotImplementedException();
        }

        public int soluongPN()
        {
            return entities.PhieuNhaps.Count();
        }

        public decimal layTongTienPN(string maPN)
        {
            decimal total = 0;
            var q = entities.Ct_PhieuNhap.Where(t => t.mapn == maPN);
            foreach (var ct in q)
            {
                total += ct.thanhtien;
            }
            return total;
        }
    }
}
