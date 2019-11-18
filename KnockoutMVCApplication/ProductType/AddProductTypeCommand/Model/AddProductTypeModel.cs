using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockoutMVCApplication.ProductType.AddProductTypeCommand.Model
{
    public class AddProductTypeModel
    {
        public int Product_Type_Code { get; set; }
        public int? Parent_Product_Type_Code { get; set; }
        public string Product_Type_Description { get; set; }
    }
}
