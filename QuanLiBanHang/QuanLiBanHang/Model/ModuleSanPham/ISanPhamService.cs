using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.Model
{
    public interface ISanPhamService
    {
        IEnumerable DanhSachSanPham();
        IEnumerable TimKiemSanPham(String str);
        bool SuaSanPham(HangHoa sp);
        bool ThemSanPham(HangHoa sp);
        bool XoaSanPham(String ma);
        HangHoa TimKiemMotSanPham(String ma);
        String SinhMaSanPham();
        bool CapNhatSoLuong(String ma, String table, decimal sl);
    }
}
