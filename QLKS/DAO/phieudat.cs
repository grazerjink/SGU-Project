//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class phieudat
    {
        public phieudat() { }
        public phieudat(string maphieudat, string cmnd, string manv, string sophong, string ngaydenthue, string ngaydi, string trangthai)
        {
            this.maphieudat = maphieudat;
            this.cmnd = cmnd;
            this.manv = manv;
            this.sophong = sophong;
            this.ngaydenthue = ngaydenthue;
            this.ngaydi = ngaydi;
            this.trangthai = trangthai;
        }

        public string maphieudat { get; set; }
        public string manv { get; set; }
        public string cmnd { get; set; }
        public string sophong { get; set; }
        public string ngaydenthue { get; set; }
        public string ngaydi { get; set; }
        public string trangthai { get; set; }
    
        public virtual khachhang khachhang { get; set; }
        public virtual nhanvien nhanvien { get; set; }
        public virtual phong phong { get; set; }
    }
}
