using QuanLiBanHang.Model.Validation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.Model
{
    class PhieuNhapService : IPhieuNhapService
    {
        private IPhieuNhapRepository _repository;
        private IValidationDictionary _validationDictionary;

        public PhieuNhapService(IValidationDictionary validationDictionary)
            : this(validationDictionary, new PhieuNhapRepository())
        { }

        public PhieuNhapService(IValidationDictionary validationDictionary, IPhieuNhapRepository repository)
        {
            _validationDictionary = validationDictionary;
            _repository = repository;
        }

        public IEnumerable DanhSachCTPhieuNhap(string mapn, string manv, string mancc)
        {
            return _repository.dsCTPhieuNhap(mapn, manv,mancc);
        }

        public IEnumerable DanhSachNhaCungCap()
        {
            return _repository.dsNCC();
        }

        public IEnumerable DanhSachPhieuNhap()
        {
            return _repository.dsPhieuNhap();
        }

        public IEnumerable DanhSachSanPham()
        {
            return _repository.dsSanPham();
        }

        public decimal layTongTienPhieuNhap(string mapn)
        {
            return _repository.layTongTienPN(mapn);
        }

        public string SinhMaPhieuNhap()
        {
            if (_repository.soluongPN().ToString().Length == 1)
            {
                return "pn00" + (_repository.soluongPN() + 1);
            }
            if (_repository.soluongPN().ToString().Length == 2)
            {
                return "pn0" + (_repository.soluongPN() + 1);
            }
            if (_repository.soluongPN().ToString().Length == 3)
            {
                return "pn" + (_repository.soluongPN() + 1);
            }
            return null;
        }

        public bool SuaCTPhieuNhap(Ct_PhieuNhap ctpn)
        {
            try
            {
                _repository.suaCTPN(ctpn);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool SuaPhieuNhap(PhieuNhap pn)
        {
            try
            {
                _repository.suaPN(pn);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool ThemCTPhieuNhap(Ct_PhieuNhap ctpn)
        {
            try
            {
                _repository.themCTPN(ctpn);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool ThemPhieuNhap(PhieuNhap pn)
        {
            try
            {
                _repository.themPN(pn);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public PhieuNhap TimKiemMotPhieuNhap(string ma)
        {
            return _repository.layInfo_1PN(ma);
        }

        public IEnumerable TimKiemNhaCungCap(string ma)
        {
            return _repository.timKiemNCC(ma);
        }

        public IEnumerable TimKiemPhieuNhap(string ma)
        {
            return _repository.timKiemPN(ma);
        }

        public IEnumerable TimKiemSanPham(string ma)
        {
            return _repository.timKiemSP(ma);
        }

        public bool XoaCTPhieuNhap(int id)
        {
            try
            {
                _repository.xoaCTPN(id);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool XoaPhieuNhap(string maPN)
        {
            try
            {
                _repository.xoaPN(maPN);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
