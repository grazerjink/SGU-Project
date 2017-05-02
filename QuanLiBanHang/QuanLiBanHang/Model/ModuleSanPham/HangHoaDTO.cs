using System;

namespace QuanLiBanHang.Model
{
    public class HangHoaDTO
    {
        public String MAHANG { get; set; }
        public String TENHANG { get; set; }
        public String HANGSX { get; set; }
        public Nullable<decimal> SOLUONG { get; set; }
        public Nullable<decimal> DONGIA { get; set; }
        public HangHoaDTO() { }
    }
}
