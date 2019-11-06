using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDomain.Factory
{
    public class ProductTypeDomainFactory : IProductTypeDomainFactory
    {
        public ProductTypesDomain CreateProductTypesDomain()
        {
            ProductTypesDomain productTypesDomain = new ProductTypesDomain();
            return productTypesDomain;
        }

        public List<ProductTypesDomain> CreateListofProductTypesDomain()
        {
            List<ProductTypesDomain> ListProductTypesDomains = new List<ProductTypesDomain>();
            return ListProductTypesDomains;
        }
    }
}
