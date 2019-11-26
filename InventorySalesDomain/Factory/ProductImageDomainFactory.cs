using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDomain.Factory
{
    public class ProductImageDomainFactory : IProductImageDomainFactory
    {
        public List<ProductImageDomain> CreateListOfProductImageDomain()
        {
            List<ProductImageDomain> ListOfProductImageDomains = new List<ProductImageDomain>();
            return ListOfProductImageDomains;
        }

        public ProductImageDomain CreateProductImageDomain()
        {
            ProductImageDomain productImageDomain = new ProductImageDomain();
            return productImageDomain;
        }
    }
}
