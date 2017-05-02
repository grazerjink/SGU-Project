using System;
using System.Collections.Generic;

namespace QuanLiBanHang.Model
{
    public interface INhaCungCapRepository
    {
        IEnumerable<NhaCungCapDTO> dsNhaCungCap();
        NhaCungCap layInfo_1NCC(String str);
        IEnumerable<NhaCungCapDTO> timKiemNCC(String str);
        void suaNCC(NhaCungCap ncc);
        void themNCC(NhaCungCap ncc);
        void xoaNCC(String ma);
        int soluongNCC();
    }
}
