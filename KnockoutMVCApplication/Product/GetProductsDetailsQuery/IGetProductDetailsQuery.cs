using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockoutMVCApplication.Product.GetProductsDetailsQuery
{
    public interface IGetProductDetailsQuery
    {
        ProductDetailModel Execute(int id);
    }
}