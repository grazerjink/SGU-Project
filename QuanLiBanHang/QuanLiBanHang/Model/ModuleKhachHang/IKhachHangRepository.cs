using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.Model
{
    public interface IKhachHangRepository
    {
        IEnumerable<KhachHangDTO> dsKhachHang();
        KhachHang layInfo_1KH(String str);
        IEnumerable<KhachHangDTO> timKiemKH(String str);
        void suaKH(KhachHang kh);
        void themKH(KhachHang kh);
        void xoaKH(String ma);
        int soluongKH();
    }
}
