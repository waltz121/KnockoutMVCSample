using InventorySalesDomain.Factory;
using InventorySalesSampleApi.CodeRepository;
using InventorySalesSampleApi.Models;
using InventorySalesSampleApi.UnitOfWork;
using System.Web.Http;
using Unity;
using Unity.Injection;
using Unity.Lifetime;
using Unity.WebApi;

namespace InventorySalesSampleApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IProductDomainFactory, ProductDomainFactory>();
            container.RegisterType<IProductTypeDomainFactory, ProductTypeDomainFactory>();
            container.RegisterType<IProductImageDomainFactory, ProductImageDomainFactory>();

         
            container.RegisterType<InventorySalesDBEntities, InventorySalesDBEntities>(new HierarchicalLifetimeManager());
            container.RegisterType<IRepository<Product>, ProductRepository>();
            container.RegisterType<IRepository<Product_Types>, ProductTypeRepository>();
            container.RegisterType<IRepository<Product_Image>, ProductImageRepository>();

            container.RegisterType<IUnitOfWork, InventorySalesUnitOfWork>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}