using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class Option
    {
        public static int HOADON = 10;
        public static int PHIEUDAT = 11;
        public static int PHIEUTHUE = 12;
        public static int PHONG = 13;
        public static int TAIKHOAN = 14;
        public static int KHACHHANG = 15;
        public static int NHANVIEN = 16;
        public static int DICHVU = 17;
        public static int SUDUNGDICHVU = 18;

        public static int DA_NHAN = 1;
        public static int DA_HUY = 2;
        public static int DA_THANH_TOAN = 3;
        public static int SAN_SANG = 4;
        public static int BAO_TRI = 5;
        public static int DANG_THUE = 6;
        public static int DA_DAT = 7;

        public static string PD_DA_NHAN = "Đã nhận";
        public static string PD_DA_HUY = "Đã hủy";
        public static string PT_DA_THANH_TOAN = "Đã thanh toán";
        public static string P_SAN_SANG = "Sẵn sàng";
        public static string P_BAO_TRI = "Đang bảo trì";
        public static string P_DANG_THUE = "Đang thuê";
        public static string P_DA_DAT = "Đã đặt";


        public static string TYPE_PHIEUDAT = "phieudat";
        public static string TYPE_PHIEUTHUE = "phieuthue";
        public static string TYPE_HOADON = "hoadon";
        public static string TYPE_KHACHHANG = "khachhang";
        public static string TYPE_NHANVIEN = "nhanvien";
        public static string TYPE_PHONG = "phong";
        public static string TYPE_TAIKHOAN = "taikhoan";
        public static string TYPE_DICHVU = "dichvu";
    }
}
