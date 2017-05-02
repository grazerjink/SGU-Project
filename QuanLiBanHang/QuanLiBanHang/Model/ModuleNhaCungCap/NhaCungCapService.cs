using QuanLiBanHang.Model.Validation;
using System;
using System.Collections;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace QuanLiBanHang.Model
{
    class NhaCungCapService : INhaCungCapService
    {
        private INhaCungCapRepository _repository;
        private IValidationDictionary _validationDictionary;

        public NhaCungCapService(IValidationDictionary validationDictionary)
            : this(validationDictionary, new NhaCungCapRepository())
        { }

        public NhaCungCapService(IValidationDictionary validationDictionary, INhaCungCapRepository repository)
        {
            _validationDictionary = validationDictionary;
            _repository = repository;
        }

        public bool ValidateNhaCungCap(NhaCungCap nccToValidate)
        {
            _validationDictionary.Clear();
            if (nccToValidate.tenncc.Trim().Length == 0)
                _validationDictionary.AddError("TenNV", "Chưa nhập tên nhà cung cấp.");
            if (nccToValidate.sdt.Trim().Length < 7 || nccToValidate.sdt.Trim().Length > 11 || IsPhoneNumber(nccToValidate.sdt.Trim()))
                _validationDictionary.AddError("IsDienThoai", "Số điện thoại không hợp lệ hoặc chứa ký tự.");
            if (nccToValidate.sdt.Trim().Length == 0)
                _validationDictionary.AddError("DienThoai", "Chưa nhập số điện thoại.");
            if (nccToValidate.diachi.Trim().Length == 0)
                _validationDictionary.AddError("DiaChi", "Chưa nhập địa chỉ.");
            if (nccToValidate.email.Trim().Length == 0)
                _validationDictionary.AddError("Email", "Chưa nhập email.");
            if (!Regex.IsMatch(nccToValidate.email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
                _validationDictionary.AddError("IsEmail", "Email chưa đúng cú pháp.");
            return _validationDictionary.IsValid;
        }

        public bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^(\+[0-9])$").Success;
        }
        
        public IEnumerable DanhSachNhaCungCap()
        {
            return _repository.dsNhaCungCap();
        }

        public string SinhMaNhaCungCap()
        {
            if (_repository.soluongNCC().ToString().Length == 1)
            {
                return "cc00" + (_repository.soluongNCC() + 1);
            }
            if (_repository.soluongNCC().ToString().Length == 2)
            {
                return "cc0" + (_repository.soluongNCC() + 1);
            }
            if (_repository.soluongNCC().ToString().Length == 3)
            {
                return "cc" + (_repository.soluongNCC() + 1);
            }
            return null;
        }

        public bool SuaNhaCungCap(NhaCungCap ncc)
        {
            // Validation logic
            if (!ValidateNhaCungCap(ncc))
            {
                return false;
            }
            try
            {
                _repository.suaNCC(ncc);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool ThemNhaCungCap(NhaCungCap ncc)
        {
            // Validation logic
            if (!ValidateNhaCungCap(ncc))
            {
                return false;
            }
            try
            {
                _repository.themNCC(ncc);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public NhaCungCap TimKiemMotNhaCungCap(string ma)
        {
            return _repository.layInfo_1NCC(ma);
        }

        public IEnumerable TimKiemNhaCungCap(string str)
        {
            return _repository.timKiemNCC(str);
        }

        public bool XoaNhaCungCap(string ma)
        {
            try
            {
                _repository.xoaNCC(ma);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
