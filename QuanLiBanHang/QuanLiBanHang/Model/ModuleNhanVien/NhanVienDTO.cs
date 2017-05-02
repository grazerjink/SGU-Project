using System;

namespace QuanLiBanHang.Model
{
    public class NhanVienDTO
    {
        public NhanVienDTO() { }

        public string MANV { get; set; }
        public string TENNV { get; set; }
        public DateTime NGAYSINH { get; set; }
        public int CHUCVU { get; set; }
        public string DIENTHOAI { get; set; }
        public string DIACHI { get; set; }
    }
}
