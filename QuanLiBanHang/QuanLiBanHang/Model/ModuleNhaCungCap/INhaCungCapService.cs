using System;
using System.Collections;

namespace QuanLiBanHang.Model
{
    public interface INhaCungCapService
    {
        IEnumerable DanhSachNhaCungCap();
        IEnumerable TimKiemNhaCungCap(String str);
        bool SuaNhaCungCap(NhaCungCap ncc);
        bool ThemNhaCungCap(NhaCungCap ncc);
        bool XoaNhaCungCap(String ma);
        NhaCungCap TimKiemMotNhaCungCap(String ma);
        String SinhMaNhaCungCap();
    }
}
