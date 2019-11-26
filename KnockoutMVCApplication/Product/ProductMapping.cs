using AutoMapper;
using InventorySalesDomain;
using KnockoutMVCApplication.ProductImage.Command.Model;
using KnockoutMVCApplication.ProductType;
using KnockoutMVCApplication.ProductType.AddProductTypeCommand.Model;
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

                    cfg.CreateMap<ProductTypesDomain, ProductTypeDetailModel>();
                    cfg.CreateMap<ProductTypeDetailModel, ProductTypesDomain>();

                    cfg.CreateMap<ProductTypesDomain, ProductTypeListModel>();
                    cfg.CreateMap<ProductTypeListModel, ProductTypesDomain>();

                    cfg.CreateMap<ProductTypesDomain, AddProductTypeModel>();
                    cfg.CreateMap<AddProductTypeModel, ProductTypesDomain>();

                    cfg.CreateMap<ProductImageDomain, AddProductImageModel>();
                    cfg.CreateMap<AddProductImageModel, ProductImageDomain>();
                }
                );
        }
    }
}
