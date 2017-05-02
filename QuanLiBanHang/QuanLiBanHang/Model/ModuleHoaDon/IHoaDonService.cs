using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.Model
{
    public interface IHoaDonService
    {
        IEnumerable DanhSachHoaDon();
        IEnumerable DanhSachCTHoaDon(String mahd, String manv, String makh);
        IEnumerable DanhSachKhachHang();
        IEnumerable DanhSachSanPham();

        bool ThemHoaDon(HoaDon hd);
        bool ThemCTHoaDon(Ct_HoaDon cthd);

        bool XoaHoaDon(String maHD);
        bool XoaCTHoaDon(int id);

        bool SuaHoaDon(HoaDon hd);
        bool SuaCTHoaDon(Ct_HoaDon cthd);

        IEnumerable TimKiemHoaDon(String ma);
        HoaDon TimKiemMotHoaDon(String ma);
        IEnumerable TimKiemKhachHang(String ma);
        IEnumerable TimKiemSanPham(String ma);

        String SinhMaHoaDon();
        decimal layTongTienHoaDon(String mahd);
    }
}
