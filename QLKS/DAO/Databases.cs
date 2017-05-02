using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;

namespace DAO
{
    public class Databases
    {
        private QLKSEntities entities = new QLKSEntities();
        private static Databases instance;
        private Databases() { }
        public static Databases INSTANCE
        {
            get
            {
                if (instance == null)
                {
                    instance = new Databases();
                }
                return instance;
            }
        }

        // Chung
        public IEnumerable hienThiDanhSach(int table, string trangthai)
        {
            string now = DateTime.Now.ToShortDateString();
            if (Option.PHIEUDAT == table)
            {
                if (trangthai != null)
                {
                    return (from p in entities.phieudats
                            where !p.trangthai.Equals(Option.PD_DA_HUY) && !p.trangthai.Equals(Option.PD_DA_NHAN) && p.ngaydenthue.Equals(now)
                            select new
                            {
                                maphieudat = p.maphieudat,
                                manv = p.nhanvien.manv,
                                cmnd = p.cmnd,
                                hoten = p.khachhang.hoten,
                                dienthoai = p.khachhang.dienthoai,
                                sophong = p.sophong,
                                ngaydenthue = p.ngaydenthue,
                                ngaydi = p.ngaydi,
                                trangthai = p.trangthai
                            }).ToList();
                }
                else
                {
                    return (from p in entities.phieudats
                            where !p.trangthai.Equals(Option.PD_DA_HUY) && !p.trangthai.Equals(Option.PD_DA_NHAN)
                            select new
                            {
                                maphieudat = p.maphieudat,
                                manv = p.nhanvien.manv,
                                cmnd = p.cmnd,
                                hoten = p.khachhang.hoten,
                                dienthoai = p.khachhang.dienthoai,
                                sophong = p.sophong,
                                ngaydenthue = p.ngaydenthue,
                                ngaydi = p.ngaydi,
                                trangthai = p.trangthai
                            }).ToList();
                }
            }
            else if (Option.PHIEUTHUE == table)
            {
                if (trangthai != null)
                    return (from p in entities.phieuthues
                            where p.ngaydi.Equals(now)
                            select new
                            {
                                maphieuthue = p.maphieuthue,
                                manv = p.nhanvien.manv,
                                cmnd = p.cmnd,
                                hoten = p.khachhang.hoten,
                                dienthoai = p.khachhang.dienthoai,
                                sophong = p.sophong,
                                ngaythue = p.ngaythue,
                                ngaydi = p.ngaydi,
                                trangthai = p.trangthai
                            }).ToList();
                else
                    return (from p in entities.phieuthues
                            select new
                            {
                                maphieuthue = p.maphieuthue,
                                manv = p.nhanvien.manv,
                                cmnd = p.cmnd,
                                hoten = p.khachhang.hoten,
                                dienthoai = p.khachhang.dienthoai,
                                sophong = p.sophong,
                                ngaythue = p.ngaythue,
                                ngaydi = p.ngaydi,
                                trangthai = p.trangthai
                            }).ToList();
            }
            else if (Option.PHONG == table)
            {
                if (trangthai != null)
                    return entities.phongs.Where(p => !p.trangthai.Equals("Đã đặt") && !p.trangthai.Equals("Đang thuê")).ToList();
                else
                {
                    return entities.phongs.Where(p => !p.trangthai.Equals(Option.P_BAO_TRI)).ToList();
                }
            }
            else if(Option.DICHVU == table)
            {
                return entities.dichvus.ToList();
            }
            else if (Option.SUDUNGDICHVU == table)
            {
                return entities.sudungdichvus.Where(dv => dv.maphieuthue.Equals(trangthai)).ToList();
            }
            else
            {
                return entities.hoadons.ToList();
            }
        }
        public bool them(object t)
        {
            try
            {
                if (t.GetType().Equals(typeof(phieudat)))
                {
                    entities.phieudats.Add((phieudat)t);
                }
                else if (t.GetType().Equals(typeof(phieuthue)))
                {
                    entities.phieuthues.Add((phieuthue)t);
                }
                else if (t.GetType().Equals(typeof(phong)))
                {
                    entities.phongs.Add((phong)t);
                }
                else if (t.GetType().Equals(typeof(hoadon)))
                {
                    entities.hoadons.Add((hoadon)t);
                }
                else if (t.GetType().Equals(typeof(khachhang)))
                {
                    entities.khachhangs.Add((khachhang)t);
                }

                entities.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool xoa(object t)
        {
            try
            {
                if (t.GetType().Equals(typeof(phieudat)))
                {
                    var q = entities.phieudats.Where(p => p.maphieudat == ((phieudat)t).maphieudat).First();
                    entities.phieudats.Remove(q);
                }
                else if (t.GetType().Equals(typeof(phieuthue)))
                {
                    var q = entities.phieuthues.Where(p => p.maphieuthue == ((phieuthue)t).maphieuthue).First();
                    entities.phieuthues.Remove(q);
                }
                else if (t.GetType().Equals(typeof(phong)))
                {
                    var q = entities.phongs.Where(p => p.phong1 == ((phong)t).phong1).First();
                    entities.phongs.Remove(q);
                }
                else if (t.GetType().Equals(typeof(hoadon)))
                {
                    var q = entities.hoadons.Where(p => p.mahoadon == ((hoadon)t).mahoadon).First();
                    entities.hoadons.Remove(q);
                }
                else if (t.GetType().Equals(typeof(khachhang)))
                {
                    var q = entities.khachhangs.Where(p => p.cmnd == ((khachhang)t).cmnd).First();
                    entities.khachhangs.Remove(q);
                }
                entities.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void thayDoiTrangThai(string ma, string option, int tbl)
        {
            if (Option.PHONG == tbl)
            {
                var update = entities.phongs.Where(p => p.phong1.Equals(ma)).FirstOrDefault();
                update.trangthai = option;
                entities.SaveChanges();
            }
            else if (Option.PHIEUDAT == tbl)
            {
                var update = entities.phieudats.Where(p => p.maphieudat.Equals(ma)).FirstOrDefault();
                update.trangthai = option;
                entities.SaveChanges();
            }
            else if (Option.PHIEUTHUE == tbl)
            {
                var update = entities.phieuthues.Where(t => t.maphieuthue.Equals(ma)).FirstOrDefault();
                update.trangthai = option;
                entities.SaveChanges();
            }
        }
        public long soLuong(int table)
        {
            if (Option.PHIEUDAT == table)
            {
                return entities.phieudats.Count();
            }
            else if (Option.PHIEUTHUE == table)
            {
                return entities.phieuthues.Count();
            }
            else if (Option.HOADON == table)
            {
                return entities.hoadons.Count();
            }
            else
            {
                return entities.nhanviens.Count();
            }
        }

        // Tai khoan va nhan vien
        public string kiemTraTaiKhoan(string tk, string mk)
        {
            var q = entities.taikhoans.Where(t => t.tentaikhoan.Equals(tk) && t.matkhau.Equals(mk));
            if (q.Count() != 0)
            {
                return q.First().chucvu.ToString().Trim();
            }
            else
            {
                return null;
            }
        }
        public string layMaNV(string tk)
        {
            return entities.taikhoans.Where(t => t.tentaikhoan.Equals(tk)).First().manv.ToString().Trim();
        }
        public bool kiemTraMatKhauCu(string mkcu, string manv)
        {
            var kq = entities.taikhoans.Where(tk => tk.manv.Equals(manv) && tk.matkhau.Equals(mkcu)).Count();
            if (kq > 0)
            {
                return true;
            }
            else return false;
        }
        public bool capNhatMatKhauMoi(string mkmoi, string manv)
        {
            try
            {
                var kq = entities.taikhoans.Where(tk => tk.manv.Equals(manv)).FirstOrDefault();
                kq.matkhau = mkmoi;
                entities.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public string kiemTraThongTin(string thongtin)
        {
            var q = entities.nhanviens.Where(nv => nv.email.Equals(thongtin) || nv.dienthoai.Equals(thongtin));
            if (q.Count() > 0)
                return q.First().manv;
            else
                return null;
        }

        // Khach hang
        public string kiemTraKhachHang(string cmnd)
        {
            var q = entities.khachhangs.Where(k => k.cmnd.Equals(cmnd));
            if (q.Count() > 0)
            {
                return q.First().hoten.ToString() + "-" + q.First().dienthoai.ToString().Trim();
            }
            else
            {
                return null;
            }
        }

        // Phieu thue
        public phieuthue layPhieuThue(string maphieu)
        {
            var q = entities.phieuthues.Where(p => p.maphieuthue.Equals(maphieu));
            return (phieuthue)q.First();
        }

        // Phong
        public bool suaPhong(string phong, string loai, string gia, string trangthai)
        {
            try
            {
                var kq = entities.phongs.Where(p => p.phong1.Equals(phong)).FirstOrDefault();
                kq.loaiphong = loai;
                kq.tienphong = gia;
                kq.trangthai = trangthai;
                entities.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        // Thong ke hoa don
        public IEnumerable layThongTinThang(int thang, int nam)
        {
            //SUM(cast(hd.tongtien as float)) as tongthanhtien
            var q = entities.Database.SqlQuery<thongke>("select p.phong, p.loaiphong, Count(p.phong) as solanthue, SUM(cast(hd.tongtienphong as float)) as tongtienphong, SUM(cast(hd.tongtiendichvu as float)) as tongtiendichvu from hoadon as hd, phieuthue as pt, phong as p where hd.maphieuthue = pt.maphieuthue and pt.sophong = p.phong and MONTH(CONVERT(datetime, hd.ngaythanhtoan, 103)) = {0} and YEAR(CONVERT(datetime, hd.ngaythanhtoan, 103)) = {1} group by p.phong, p.loaiphong, p.tienphong", thang, nam);
            return q.ToList();
        }
        public IEnumerable layThongTinNam(int nam)
        {
            var q = entities.Database.SqlQuery<thongke>("select p.phong, p.loaiphong, Count(p.phong) as solanthue, SUM(cast(hd.tongtienphong as float)) as tongtienphong, SUM(cast(hd.tongtiendichvu as float)) as tongtiendichvu from hoadon as hd, phieuthue as pt, phong as p where hd.maphieuthue = pt.maphieuthue and pt.sophong = p.phong and YEAR(CONVERT(datetime, hd.ngaythanhtoan, 103)) = {0} group by p.phong, p.loaiphong, p.tienphong", nam);
            return q.ToList();
        }
        public IEnumerable layThongTinQuy(string quy, int nam)
        {
            if (quy.Equals("Quý 1"))
            {
                var q = entities.Database.SqlQuery<thongke>("select p.phong, p.loaiphong, Count(p.phong) as solanthue, SUM(cast(hd.tongtienphong as float)) as tongtienphong, SUM(cast(hd.tongtiendichvu as float)) as tongtiendichvu from hoadon as hd, phieuthue as pt, phong as p where hd.maphieuthue = pt.maphieuthue and pt.sophong = p.phong and MONTH(CONVERT(datetime, hd.ngaythanhtoan, 103)) >= 1  and MONTH(CONVERT(datetime, hd.ngaythanhtoan, 103)) <= 3 and YEAR(CONVERT(datetime, hd.ngaythanhtoan, 103)) = {0} group by p.phong, p.loaiphong, p.tienphong", nam);
                return q.ToList();
            }
            else if (quy.Equals("Quý 2"))
            {
                var q = entities.Database.SqlQuery<thongke>("select p.phong, p.loaiphong, Count(p.phong) as solanthue, SUM(cast(hd.tongtienphong as float)) as tongtienphong, SUM(cast(hd.tongtiendichvu as float)) as tongtiendichvu from hoadon as hd, phieuthue as pt, phong as p where hd.maphieuthue = pt.maphieuthue and pt.sophong = p.phong and MONTH(CONVERT(datetime, hd.ngaythanhtoan, 103)) >= 4  and MONTH(CONVERT(datetime, hd.ngaythanhtoan, 103)) <= 6 and YEAR(CONVERT(datetime, hd.ngaythanhtoan, 103)) = {0} group by p.phong, p.loaiphong, p.tienphong", nam);
                return q.ToList();
            }
            else if (quy.Equals("Quý 3"))
            {
                var q = entities.Database.SqlQuery<thongke>("select p.phong, p.loaiphong, Count(p.phong) as solanthue, SUM(cast(hd.tongtienphong as float)) as tongtienphong, SUM(cast(hd.tongtiendichvu as float)) as tongtiendichvu from hoadon as hd, phieuthue as pt, phong as p where hd.maphieuthue = pt.maphieuthue and pt.sophong = p.phong and MONTH(CONVERT(datetime, hd.ngaythanhtoan, 103)) >= 7  and MONTH(CONVERT(datetime, hd.ngaythanhtoan, 103)) <= 9 and YEAR(CONVERT(datetime, hd.ngaythanhtoan, 103)) = {0} group by p.phong, p.loaiphong, p.tienphong", nam);
                return q.ToList();
            }
            else if (quy.Equals("Quý 4"))
            {
                var q = entities.Database.SqlQuery<thongke>("select p.phong, p.loaiphong, Count(p.phong) as solanthue, SUM(cast(hd.tongtienphong as float)) as tongtienphong, SUM(cast(hd.tongtiendichvu as float)) as tongtiendichvu from hoadon as hd, phieuthue as pt, phong as p where hd.maphieuthue = pt.maphieuthue and pt.sophong = p.phong and MONTH(CONVERT(datetime, hd.ngaythanhtoan, 103)) >= 10  and MONTH(CONVERT(datetime, hd.ngaythanhtoan, 103)) <= 12 and YEAR(CONVERT(datetime, hd.ngaythanhtoan, 103)) = {0} group by p.phong, p.loaiphong, p.tienphong", nam);
                return q.ToList();
            }
            else
            {
                return null;
            }
        }
        public hoadon layHoaDon(string mahd)
        {
            return entities.hoadons.Where(hd => hd.mahoadon == mahd).FirstOrDefault();
        }

        //Dich vu
        public string layGiaTienDichVu(string tendichvu)
        {
            return entities.dichvus.Where(d => d.tendichvu.Equals(tendichvu)).First().gia;
        }

        public bool themDichVu(List<sudungdichvu> list)
        {
            try
            {
                foreach(sudungdichvu dv in list)
                {
                    entities.sudungdichvus.Add(dv);
                }
                entities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                return false;
            }
        }
    }
}
