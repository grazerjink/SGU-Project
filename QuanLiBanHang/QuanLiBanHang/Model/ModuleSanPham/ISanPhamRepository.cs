using System;
using System.Collections.Generic;

namespace QuanLiBanHang.Model
{
    public interface ISanPhamRepository
    {
        IEnumerable<HangHoaDTO> dsSanPham();
        HangHoa layInfo_1SP(String str);
        IEnumerable<HangHoaDTO> timKiemSP(String str);
        void suaSP(HangHoa sp);
        void themSP(HangHoa sp);
        void xoaSP(String ma);
        int soluongSP();
        void capNhatSLSP(String ma, String table, decimal sl);
    }
}
