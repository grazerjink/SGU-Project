using System;
using System.Collections;

namespace QuanLiBanHang.Model
{
    public interface IPhieuNhapService
    {
        IEnumerable DanhSachPhieuNhap();
        IEnumerable DanhSachCTPhieuNhap(String mapn, String manv, String mancc);
        IEnumerable DanhSachNhaCungCap();
        IEnumerable DanhSachSanPham();

        bool ThemPhieuNhap(PhieuNhap pn);
        bool ThemCTPhieuNhap(Ct_PhieuNhap ctpn);

        bool XoaPhieuNhap(String maPN);
        bool XoaCTPhieuNhap(int id);

        bool SuaPhieuNhap(PhieuNhap pn);
        bool SuaCTPhieuNhap(Ct_PhieuNhap ctpn);

        IEnumerable TimKiemPhieuNhap(String ma);
        PhieuNhap TimKiemMotPhieuNhap(String ma);
        IEnumerable TimKiemNhaCungCap(String ma);
        IEnumerable TimKiemSanPham(String ma);

        String SinhMaPhieuNhap();
        decimal layTongTienPhieuNhap(String mapn);
    }
}
