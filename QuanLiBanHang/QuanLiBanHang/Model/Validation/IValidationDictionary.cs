using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLiBanHang.Model.Validation
{
    public interface IValidationDictionary
    {
        void Clear();
        void AddError(string key, string errorMessage);
        bool IsValid { get; }
    }
}
