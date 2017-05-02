using System;
using System.Collections.Generic;

namespace QuanLiBanHang.Model
{
    public interface IHoaDonRepository
    {
        IEnumerable<HoaDonDTO> dsHoaDon();
        IEnumerable<ctHoaDonDTO> dsCTHoaDon(String mahd, String manv, String makh);
        IEnumerable<HoaDonDTO> timKiemHD(String str);
        IEnumerable<HangHoaDTO_HD> dsSanPham();
        IEnumerable<KhachHangDTO_HD> dsKhachHang();
        IEnumerable<HangHoaDTO_HD> timKiemSP(String str);
        IEnumerable<KhachHangDTO_HD> timKiemKH(String str);

        HoaDon layInfo_1HD(String ma);
        Ct_HoaDon layInfo_1CTHD(int id);
        IEnumerable<Ct_HoaDon> layInfo_CTHD(String ma);

        void suaHD(HoaDon hd);
        void themHD(HoaDon hd);
        void xoaHD(String ma);
        void themCTHD(Ct_HoaDon cthd);
        void suaCTHD(Ct_HoaDon cthd);
        void xoaCTHD(int id);
        void xoaSachCTHD(String mahd);

        int soluongHD();
        decimal layTongTienHD(String mahd);
    }
}
