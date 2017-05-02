using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.Model
{
    public class KhachHangDTO
    {
        public KhachHangDTO()
        {
        }

        public string MAKH { get; set; }
        public string TENKH { get; set; }
        public string DIENTHOAI { get; set; }
        public string DIACHI { get; set; }
        public Nullable<int> TIEMNANG { get; set; }
    }
}
