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
    
    public partial class phong
    {
        public phong()
        {
            this.phieudats = new HashSet<phieudat>();
            this.phieuthues = new HashSet<phieuthue>();
        }

        public phong(string phong1, string loaiphong, string tienphong, string trangthai)
        {
            this.phong1 = phong1;
            this.loaiphong = loaiphong;
            this.tienphong = tienphong;
            this.trangthai = trangthai;
        }

        public phong(string phong1)
        {
            this.phong1 = phong1;
        }

        public int stt { get; set; }
        public string phong1 { get; set; }
        public string loaiphong { get; set; }
        public string tienphong { get; set; }
        public string trangthai { get; set; }
    
        public virtual ICollection<phieudat> phieudats { get; set; }
        public virtual ICollection<phieuthue> phieuthues { get; set; }
    }
}
