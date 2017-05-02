using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.Model
{
    public class ctHoaDonDTO
    {
        public ctHoaDonDTO() { }

        public int STT { get; set; }
        public String MAHANG { get; set; }
        public String TENNV { get; set; }
        public String TENKH { get; set; }
        public String TENHANG { get; set; }
        public Nullable<decimal> SOLUONG { get; set; }
        public Nullable<decimal> GIABAN { get; set; }

    }
}
