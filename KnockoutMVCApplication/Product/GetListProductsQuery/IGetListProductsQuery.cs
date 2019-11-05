using InventorySalesDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockoutMVCApplication.Product.GetListProductsQuery
{
    public interface IGetListProductsQuery
    {
        List<ProductGridModel> Execute();
    }
}
