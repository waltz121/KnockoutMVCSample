using AutoMapper;
using InventorySalesDomain;
using KnockoutMVCApplication.ProductType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockoutMVCApplication.Product
{
    public static class ProductMapping
    {
        public static MapperConfiguration MapConfig;

        public static void Execute()
        {
            MapConfig = new MapperConfiguration(
                cfg =>
                {
                    cfg.CreateMap<ProductDomain, ProductGridModel>();
                    cfg.CreateMap<ProductGridModel, ProductDomain>();

                    cfg.CreateMap<ProductTypesDomain, ProductTypeListModel>();
                    cfg.CreateMap<ProductTypeListModel, ProductTypesDomain>();
                }
                );
        }
    }
}
