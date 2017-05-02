using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLiBanHang.Model.Validation
{
    public class ModelStateDictionary : Dictionary<string, string>
    {
        internal void AddModelError(string key, string errorMessage)
        {
            this.Add(key, errorMessage);
        }

        public bool IsValid
        {
            get { return (this.Count <= 0); }
        }
    }
}
