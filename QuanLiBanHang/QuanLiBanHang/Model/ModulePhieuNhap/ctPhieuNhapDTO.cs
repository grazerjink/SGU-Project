using System;

namespace QuanLiBanHang.Model
{
    public class ctPhieuNhapDTO
    {
        public ctPhieuNhapDTO() { }

        public int STT { get; set; }
        public String MAHANG { get; set; }
        public String TENNV { get; set; }
        public String TENNCC { get; set; }
        public String TENHANG { get; set; }
        public Nullable<decimal> SOLUONG { get; set; }
        public Nullable<decimal> GIANHAP { get; set; }

    }
}
