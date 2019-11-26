using InventorySalesDomain.Factory;
using KnockoutMVCApplication.Product.GetListProductsQuery;
using KnockoutMVCApplication.Product.GetProductsDetailsQuery;
using KnockoutMVCApplication.ProductType.AddProductTypeCommand;
using KnockoutMVCApplication.ProductType.DeleteProductTypeCommand;
using KnockoutMVCApplication.ProductType.GetListOfProductTypesQuery;
using KnockoutMVCApplication.ProductType.GetViaIdProductTypesQuery;
using KnockoutMVCApplication.ProductType.UpdateProductTypesCommand;
using KnockoutMVCCommons.HttpRequest.RequestDelete;
using KnockoutMVCCommons.HttpRequest.RequestGet;
using KnockoutMVCCommons.HttpRequest.RequestPost;
using KnockoutMVCCommons.HttpRequest.RequestPut;
using Unity;

namespace KnockoutMVCBootstrap
{
    public static class UnityConfig
    {
        public static UnityContainer RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            //DependencyResolver.SetResolver(new UnityDependencyResolver(container));
          

            container.RegisterType<IHttpRequestGet, HttpRequestGet>();
            container.RegisterType<IHttpRequestPost, HttpRequestPost>();
            container.RegisterType<IHttpRequestPut, HttpRequestPut>();
            container.RegisterType<IHttpRequestDelete, HttpRequestDelete>();

            container.RegisterType<IProductTypeDomainFactory, ProductTypeDomainFactory>();

            container.RegisterType<IGetListProductsQuery, GetListProductsQuery>();
            container.RegisterType<IGetProductDetailsQuery, GetProductDetailsQuery>();

            container.RegisterType<IAddProductTypeCommand, AddProductTypeCommand>();
            container.RegisterType<IGetListOfProductTypesQuery, GetListOfProductTypesQuery>();
            container.RegisterType<IGetViaIdProductTypesQuery, GetViaIdProductTypesQuery>();
            container.RegisterType<IDeleteProductTypeCommand, DeleteProductTypeCommand>();
            container.RegisterType<IUpdateProductTypesCommand, UpdateProductTypesCommand>();

            return container;
        }
    }
}