using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDomain.Factory
{
    public class ProductDomainFactory : IProductDomainFactory
    {
        public ProductDomain CreateProductDomain()
        {
            ProductDomain productDomain = new ProductDomain();
            return productDomain;
        }

        public List<ProductDomain> CreateListofProductDomain()
        {
            List<ProductDomain> ProductDomainsList = new List<ProductDomain>();
            return ProductDomainsList;
        }
    }
}
