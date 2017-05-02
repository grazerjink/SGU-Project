using System;
using System.Collections.Generic;

namespace QuanLiBanHang.Model
{
    public interface INhanVienRepository
    {
        IEnumerable<NhanVienDTO> dsNhanVien();
        NhanVien layInfo_1NV(String str);
        IEnumerable<NhanVienDTO> timKiemNV(String str);
        void suaNV(NhanVien nv);
        void themNV(NhanVien nv);
        void xoaNV(String ma);
        void themTaiKhoan(TaiKhoan tk);
        int soluongNV();
    }
}
