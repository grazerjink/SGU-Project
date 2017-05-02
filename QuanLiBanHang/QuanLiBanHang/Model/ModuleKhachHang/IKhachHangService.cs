using System;
using System.Collections;

namespace QuanLiBanHang.Model
{
    public interface IKhachHangService
    {
        IEnumerable DanhSachKhachHang();
        IEnumerable TimKiemKhachHang(String str);
        bool SuaKhachHang(KhachHang ncc);
        bool ThemKhachHang(KhachHang ncc);
        bool XoaKhachHang(String ma);
        KhachHang TimKiemMotKhachHang(String ma);
        String SinhMaKhachHang();
    }
}
