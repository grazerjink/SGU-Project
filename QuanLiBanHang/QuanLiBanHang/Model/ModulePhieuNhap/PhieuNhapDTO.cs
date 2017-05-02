using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.Model
{
    public class PhieuNhapDTO
    {
        public PhieuNhapDTO()
        {
        }

        public string MAPN { get; set; }
        public string MANV { get; set; }
        public string MANCC { get; set; }
        public System.DateTime NGAYNHAP { get; set; }
        public decimal TONGTIEN { get; set; }
    }
}
