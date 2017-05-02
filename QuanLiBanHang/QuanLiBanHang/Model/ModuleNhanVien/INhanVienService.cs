using System;
using System.Collections;

namespace QuanLiBanHang.Model
{
    public interface INhanVienService
    {
        IEnumerable DanhSachNhanVien();
        IEnumerable TimKiemNhanVien(String str);
        bool SuaNhanVien(NhanVien nv);
        bool ThemNhanVien(NhanVien nv);
        bool XoaNhanVien(String ma);
        NhanVien TimKiemMotNhanVien(String ma);
        bool ThemTaiKhoan(TaiKhoan tk);
        String SinhMaNhanVien();
    }
}
