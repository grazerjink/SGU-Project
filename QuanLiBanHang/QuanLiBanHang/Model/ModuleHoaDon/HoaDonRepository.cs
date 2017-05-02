using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLiBanHang.Model
{
    class HoaDonRepository : IHoaDonRepository
    {
        private QLBHEntities entities = new QLBHEntities();

        public HoaDon layInfo_1HD(String ma)
        {
            var q = entities.HoaDons.Where(t => t.mahd.Contains(ma));
            return q.FirstOrDefault();
        }

        public IEnumerable<Ct_HoaDon> layInfo_CTHD(String ma)
        {
            var q = entities.Ct_HoaDon.Where(t => t.mahd.Contains(ma));
            return q;
        }

        public IEnumerable<HoaDonDTO> dsHoaDon()
        {
            return (from h in entities.HoaDons select new HoaDonDTO() { MAHD = h.mahd, MANV = h.manv, MAKH = h.makh, NGAYXUAT = h.ngayxuat, TONGTIEN = h.tongtien }).ToArray();
        }

        public IEnumerable<ctHoaDonDTO> dsCTHoaDon(String mahd, String manv, String makh)
        {
                return ( from d in entities.Ct_HoaDon
                         //join nv in entities.NhanViens on manv equals nv.manv
                         //join hh in entities.HangHoas on d.mahang equals hh.mahang
                         //join kh in entities.KhachHangs on makh equals kh.makh
                         where d.mahd == mahd
                         select new ctHoaDonDTO() { STT = d.id, TENNV = d.HoaDon.NhanVien.tennv, TENKH = d.HoaDon.KhachHang.tenkh, MAHANG = d.mahang, TENHANG = d.HangHoa.tenhang, SOLUONG = d.soluong, GIABAN = d.giaban }).ToList();
        }
        

        public IEnumerable<HangHoaDTO_HD> dsSanPham()
        {
            return (from h in entities.HangHoas select new HangHoaDTO_HD { MAHANG = h.mahang, TENHANG = h.tenhang, SOLUONG = h.soluong, DONGIA = h.dongia }).ToList();
        }

        public IEnumerable<KhachHangDTO_HD> dsKhachHang()
        {
            return (from h in entities.KhachHangs select new KhachHangDTO_HD { MAKH = h.makh, TENKH = h.tenkh, DIENTHOAI = h.dienthoai }).ToList();
        }

        public void themHD(HoaDon hd)
        {
            entities.HoaDons.Add(hd);
            entities.SaveChanges();
        }

        public void themCTHD(Ct_HoaDon cthd)
        {
            entities.Ct_HoaDon.Add(cthd);
            entities.SaveChanges();
        }

        public void suaHD(HoaDon hd)
        {
            var q = layInfo_1HD(hd.mahd);
            q.makh = hd.makh;
            q.tongtien = hd.tongtien;
            entities.SaveChanges();
        }

        public void suaCTHD(Ct_HoaDon cthd)
        {
            //Chưa nghĩ ra
        }

        public void xoaHD(String ma)
        {
            var code = layInfo_1HD(ma);
            entities.HoaDons.Remove(code);
            entities.SaveChanges();
        }

        public void xoaCTHD(int id)
        {
            var code = layInfo_1CTHD(id);
            entities.Ct_HoaDon.Remove(code);
            entities.SaveChanges();
        }

        public Ct_HoaDon layInfo_1CTHD(int id)
        {
           var q = entities.Ct_HoaDon.Where(t => t.id == id);
           return q.FirstOrDefault();
        }

        public void xoaSachCTHD(string mahd)
        {
            var codes = layInfo_CTHD(mahd);
            foreach (var item in codes)
            {
                entities.Ct_HoaDon.Remove(item);
                entities.SaveChanges();
            }
        }

        public int soluongHD()
        {
            return entities.HoaDons.Count();
        }

        public IEnumerable<HangHoaDTO_HD> timKiemSP(string str)
        {
            var q = entities.HangHoas.Where(t => t.mahang.Contains(str) || t.tenhang.Contains(str) || t.hangsx.Contains(str));
            return (from h in q select new HangHoaDTO_HD { MAHANG = h.mahang, TENHANG = h.tenhang, SOLUONG = h.soluong, DONGIA = h.dongia }).ToList();
        }

        public IEnumerable<KhachHangDTO_HD> timKiemKH(string str)
        {
            var q = entities.KhachHangs.Where(t => t.makh.Contains(str) || t.tenkh.Contains(str) || t.dienthoai.Contains(str));
            return (from h in q select new KhachHangDTO_HD { MAKH = h.makh, TENKH = h.tenkh, DIENTHOAI = h.dienthoai } ).ToList();
        }

        public IEnumerable<HoaDonDTO> timKiemHD(String str)
        {
            var q = entities.HoaDons.Where(t => t.mahd.Contains(str) || t.makh.Contains(str) || t.manv.Contains(str) || t.ngayxuat.ToString().Contains(str) || t.tongtien.ToString().Contains(str));
            return (from h in q select new HoaDonDTO { MAHD = h.mahd, MANV = h.manv, MAKH = h.makh, NGAYXUAT = h.ngayxuat, TONGTIEN = h.tongtien }).ToList();
        }

        public decimal layTongTienHD(string mahd)
        {
            decimal total = 0 ;
            var q = entities.Ct_HoaDon.Where(t => t.mahd == mahd);
            foreach (var ct in q)
            {
                total += ct.thanhtien;
            }
            return total;
        }
    }
}
