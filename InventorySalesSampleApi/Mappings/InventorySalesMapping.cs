using AutoMapper;
using InventorySalesDomain;
using InventorySalesSampleApi.Models;

namespace InventorySalesSampleApi.Mappings
{
    public static class InventorySalesMapping
    {
        public static MapperConfiguration MapConfig;

        public static void Execute()
        {
            MapConfig = new MapperConfiguration(
                cfg =>
                {
                    cfg.CreateMap<Product, ProductDomain>();
                    cfg.CreateMap<ProductDomain, Product>();
                }
                );
        }
    }
}