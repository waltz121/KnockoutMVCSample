using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDomain.Factory
{
    public interface IProductDomainFactory
    {
        ProductDomain CreateProductDomain();
        List<ProductDomain> CreateListofProductDomain();


    }
}
