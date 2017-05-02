using QuanLiBanHang.Model.Validation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.Model
{
    class SanPhamService : ISanPhamService
    {
        private ISanPhamRepository _repository;
        private IValidationDictionary _validationDictionary;

        public SanPhamService(IValidationDictionary validationDictionary)
            : this(validationDictionary, new SanPhamRepository())
        { }

        public SanPhamService(IValidationDictionary validationDictionary, ISanPhamRepository repository)
        {
            _validationDictionary = validationDictionary;
            _repository = repository;
        }

        public bool ValidateSanPham(HangHoa spToValidate)
        {
            _validationDictionary.Clear();
            if (spToValidate.tenhang.Trim().Length == 0)
                _validationDictionary.AddError("TenHang", "Chưa nhập tên hàng.");
            if (spToValidate.hangsx.Trim().Length == 0)
                _validationDictionary.AddError("HangSX", "Chưa nhập hãng sản xuất.");
            if (spToValidate.dongia == 0)
                _validationDictionary.AddError("DonGia", "Chưa khai báo đơn giá bán.");
            if (spToValidate.soluong == 0 )
                _validationDictionary.AddError("SoLuong", "Chưa khai báo số lượng hàng.");
            return _validationDictionary.IsValid;
        }


        public IEnumerable DanhSachSanPham()
        {
            return _repository.dsSanPham();
        }

        public bool SuaSanPham(HangHoa sp)
        {
            // Validation logic
            if (!ValidateSanPham(sp))
            {
                return false;
            }
            try
            {
                _repository.suaSP(sp);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool ThemSanPham(HangHoa sp)
        {
            // Validation logic
            if (!ValidateSanPham(sp))
            {
                return false;
            }
            try
            {
                _repository.themSP(sp);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public IEnumerable TimKiemSanPham(string str)
        {
            return _repository.timKiemSP(str);
        }

        public bool XoaSanPham(string ma)
        {
            try
            {
                _repository.xoaSP(ma);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public HangHoa TimKiemMotSanPham(String ma)
        {
            return _repository.layInfo_1SP(ma);
        }

        public String SinhMaSanPham()
        {
            if(_repository.soluongSP().ToString().Length == 1)
            {
                return "sp00" + (_repository.soluongSP() + 1);
            }
            if(_repository.soluongSP().ToString().Length == 2)
            {
                return "sp0" + (_repository.soluongSP() + 1);
            }
            if (_repository.soluongSP().ToString().Length == 3)
            {
                return "sp" + (_repository.soluongSP() + 1);
            }
            return null;
        }

        public bool CapNhatSoLuong(string ma, String table, decimal sl)
        {
            try
            {
                _repository.capNhatSLSP(ma, table, sl);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
