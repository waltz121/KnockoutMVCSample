using System.Collections.Generic;

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
