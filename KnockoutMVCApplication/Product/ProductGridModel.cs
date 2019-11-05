using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockoutMVCApplication.Product
{
    public class ProductGridModel
    {
        public int Id { get; set; }
        public decimal Unit_Price { get; set; }
        public string Product_Name { get; set; }
        public string Product_Description { get; set; }
    }
}
