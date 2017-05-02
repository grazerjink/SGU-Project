using QuanLiBanHang.Model.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QuanLiBanHang.Model
{
    class HoaDonService : IHoaDonService
    {
        private IHoaDonRepository _repository;
        private IValidationDictionary _validationDictionary;

        public HoaDonService(IValidationDictionary validationDictionary)
            : this(validationDictionary, new HoaDonRepository())
        { }

        public HoaDonService(IValidationDictionary validationDictionary, IHoaDonRepository repository)
        {
            _validationDictionary = validationDictionary;
            _repository = repository;
        }

        public IEnumerable DanhSachHoaDon()
        {
            return _repository.dsHoaDon();
        }

        public IEnumerable DanhSachCTHoaDon(String mahd, String manv, String makh)
        {
            return _repository.dsCTHoaDon(mahd, manv, makh);
        }

        public IEnumerable DanhSachKhachHang()
        {
            return _repository.dsKhachHang();
        }

        public IEnumerable DanhSachSanPham()
        {
            return _repository.dsSanPham();
        }

        public string SinhMaHoaDon()
        {
            if (_repository.soluongHD().ToString().Length == 1)
            {
                return "hd00" + (_repository.soluongHD() + 1);
            }
            if (_repository.soluongHD().ToString().Length == 2)
            {
                return "hd0" + (_repository.soluongHD() + 1);
            }
            if (_repository.soluongHD().ToString().Length == 3)
            {
                return "hd" + (_repository.soluongHD() + 1);
            }
            return null;
        }

        public bool SuaCTHoaDon(Ct_HoaDon cthd)
        {
            try
            {
                _repository.suaCTHD(cthd);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool SuaHoaDon(HoaDon hd)
        {
            try
            {
                _repository.suaHD(hd);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool ThemCTHoaDon(Ct_HoaDon cthd)
        {
            try
            {
                _repository.themCTHD(cthd);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool ThemHoaDon(HoaDon hd)
        {
            try
            {
                _repository.themHD(hd);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public IEnumerable TimKiemHoaDon(String ma)
        {
            return _repository.timKiemHD(ma);
        }

        public HoaDon TimKiemMotHoaDon(string ma)
        {
            return _repository.layInfo_1HD(ma);
        }

        public bool XoaCTHoaDon(int id)
        {
            try
            {
                _repository.xoaCTHD(id);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool XoaHoaDon(String maHD)
        {
            try
            {
                _repository.xoaHD(maHD);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public IEnumerable TimKiemKhachHang(string ma)
        {
            return _repository.timKiemKH(ma);
        }

        public IEnumerable TimKiemSanPham(string ma)
        {
            return _repository.timKiemKH(ma);
        }

        public decimal layTongTienHoaDon(string mahd)
        {
            return _repository.layTongTienHD(mahd);
        }
    }
}
