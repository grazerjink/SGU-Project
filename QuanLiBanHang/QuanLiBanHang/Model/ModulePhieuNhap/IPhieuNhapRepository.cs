using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.Model
{
    public interface IPhieuNhapRepository
    {
        IEnumerable<PhieuNhapDTO> dsPhieuNhap();
        IEnumerable<ctPhieuNhapDTO> dsCTPhieuNhap(String maPN, String manv, String makh);
        IEnumerable<PhieuNhapDTO> timKiemPN(String str);
        IEnumerable<HangHoaDTO_HD> dsSanPham();
        IEnumerable<NhaCungCapDTO_HD> dsNCC();
        IEnumerable<HangHoaDTO_HD> timKiemSP(String str);
        IEnumerable<NhaCungCapDTO_HD> timKiemNCC(String str);

        PhieuNhap layInfo_1PN(String ma);
        Ct_PhieuNhap layInfo_1CTPN(int id);
        IEnumerable<Ct_PhieuNhap> layInfo_CTPN(String ma);

        void suaPN(PhieuNhap PN);
        void themPN(PhieuNhap PN);
        void xoaPN(String ma);
        void themCTPN(Ct_PhieuNhap ctPN);
        void suaCTPN(Ct_PhieuNhap ctPN);
        void xoaCTPN(int id);
        void xoaSachCTPN(String maPN);

        int soluongPN();
        decimal layTongTienPN(String maPN);
    }
}
