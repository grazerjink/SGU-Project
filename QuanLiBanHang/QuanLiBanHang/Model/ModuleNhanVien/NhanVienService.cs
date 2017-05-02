using QuanLiBanHang.Model;
using QuanLiBanHang.Model.Validation;
using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace QuanLiBanHang.Model
{
    public class NhanVienService : INhanVienService
    {
        private INhanVienRepository _repository;
        private IValidationDictionary _validationDictionary;

        public NhanVienService(IValidationDictionary validationDictionary)
            : this(validationDictionary, new NhanVienRepository())
        { }

        public NhanVienService(IValidationDictionary validationDictionary, INhanVienRepository repository)
        {
            _validationDictionary = validationDictionary;
            _repository = repository;
        }

        public bool ValidateNhanVien(NhanVien nvToValidate)
        {
            _validationDictionary.Clear();
            if (nvToValidate.tennv.Trim().Length == 0)
                _validationDictionary.AddError("TenNV", "Chưa nhập tên nhân viên.");
            if (nvToValidate.dienthoai.Trim().Length < 10 || nvToValidate.dienthoai.Trim().Length > 11 || IsPhoneNumber(nvToValidate.dienthoai.Trim()))
                _validationDictionary.AddError("DienThoai", "Chưa nhập số điện hoặc chứa ký tự.");
            if (nvToValidate.diachi.Trim().Length == 0)
                _validationDictionary.AddError("DiaChi", "Chưa nhập địa chỉ.");
            return _validationDictionary.IsValid;
        }

        public bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^(\+[0-9])$").Success;
        }

        public IEnumerable DanhSachNhanVien()
        {
            return _repository.dsNhanVien();
        }

        public bool SuaNhanVien(NhanVien nv)
        {
            // Validation logic
            if (!ValidateNhanVien(nv))
            {
                return false;
            }
            try
            {
                _repository.suaNV(nv);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool ThemNhanVien(NhanVien nv)
        {
            // Validation logic
            if (!ValidateNhanVien(nv))
            {
                return false;
            }
            try
            {
                _repository.themNV(nv);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public IEnumerable TimKiemNhanVien(string str)
        {
            return _repository.timKiemNV(str);
        }

        public bool XoaNhanVien(string ma)
        {
            try
            {
                _repository.xoaNV(ma);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public NhanVien TimKiemMotNhanVien(String ma)
        {
            return _repository.layInfo_1NV(ma);
        }

        public string SinhMaNhanVien()
        {

            if (_repository.soluongNV().ToString().Length == 1)
            {
                return "nv00" + (_repository.soluongNV() + 1);
            }
            if (_repository.soluongNV().ToString().Length == 2)
            {
                return "nv0" + (_repository.soluongNV() + 1);
            }
            if (_repository.soluongNV().ToString().Length == 3)
            {
                return "nv" + (_repository.soluongNV() + 1);
            }
            return null;
        }

        public bool ThemTaiKhoan(TaiKhoan tk)
        {
            if (!ValidateTaiKhoan(tk))
            {
                return false;
            }
            try
            {
                _repository.themTaiKhoan(tk);
            }
            catch
            {
                return false;
            }
            return true;
        }

        private bool ValidateTaiKhoan(TaiKhoan tk)
        {
            _validationDictionary.Clear();
            if (tk.taikhoan1.Trim().Length == 0)
                _validationDictionary.AddError("TaiKhoan", "Chưa nhập tên tài khoản.");
            if (tk.matkhau.Trim().Length < 5 || tk.matkhau.Trim().Length > 16)
                _validationDictionary.AddError("MatKhau", "Chưa nhập mật khẩu.");
            return _validationDictionary.IsValid;
        }
    }
}
