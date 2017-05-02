using QuanLiBanHang.Model.Validation;
using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace QuanLiBanHang.Model
{
    class KhachHangService : IKhachHangService
    {
        private IKhachHangRepository _repository;
        private IValidationDictionary _validationDictionary;

        public KhachHangService(IValidationDictionary validationDictionary)
            : this(validationDictionary, new KhachHangRepository())
        { }

        public KhachHangService(IValidationDictionary validationDictionary, IKhachHangRepository repository)
        {
            _validationDictionary = validationDictionary;
            _repository = repository;
        }

        public bool ValidateKhachHang(KhachHang khToValidate)
        {
            _validationDictionary.Clear();
            if (khToValidate.tenkh.Trim().Length == 0)
                _validationDictionary.AddError("TenKH", "Chưa nhập tên khách hàng.");
            if (khToValidate.dienthoai.Trim().Length < 10 || khToValidate.dienthoai.Trim().Length > 11 || IsPhoneNumber(khToValidate.dienthoai.Trim()))
                _validationDictionary.AddError("DienThoai", "Chưa nhập số điện hoặc chứa ký tự.");
            if (khToValidate.diachi.Trim().Length == 0)
                _validationDictionary.AddError("DiaChi", "Chưa nhập địa chỉ.");
            return _validationDictionary.IsValid;
        }

        public bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^(\+[0-9])$").Success;
        }

        public IEnumerable DanhSachKhachHang()
        {
            return _repository.dsKhachHang();
        }

        public string SinhMaKhachHang()
        {
            if (_repository.soluongKH().ToString().Length == 1)
            {
                return "kh00" + (_repository.soluongKH() + 1);
            }
            if (_repository.soluongKH().ToString().Length == 2)
            {
                return "kh0" + (_repository.soluongKH() + 1);
            }
            if (_repository.soluongKH().ToString().Length == 3)
            {
                return "kh" + (_repository.soluongKH() + 1);
            }
            return null;
        }

        public bool SuaKhachHang(KhachHang kh)
        {
            // Validation logic
            if (!ValidateKhachHang(kh))
            {
                return false;
            }
            try
            {
                _repository.suaKH(kh);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool ThemKhachHang(KhachHang kh)
        {
            // Validation logic
            if (!ValidateKhachHang(kh))
            {
                return false;
            }
            try
            {
                _repository.themKH(kh);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public IEnumerable TimKiemKhachHang(string str)
        {
            return _repository.timKiemKH(str);
        }

        public KhachHang TimKiemMotKhachHang(string ma)
        {
            return _repository.layInfo_1KH(ma);
        }

        public bool XoaKhachHang(string ma)
        {
            try
            {
                _repository.xoaKH(ma);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
