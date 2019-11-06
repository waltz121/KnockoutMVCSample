using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDomain.Factory
{
    public interface IProductTypeDomainFactory
    {
        ProductTypesDomain CreateProductTypesDomain();
        List<ProductTypesDomain> CreateListofProductTypesDomain();
    }
}
