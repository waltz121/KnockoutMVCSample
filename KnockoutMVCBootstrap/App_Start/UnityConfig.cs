using InventorySalesSampleApi.CodeRepository;
using InventorySalesSampleApi.Models;
using InventorySalesSampleApi.UnitOfWork;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

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

            container.RegisterType<IRepository<Product>, ProductRepository>();
            container.RegisterType<IUnitOfWork, InventorySalesUnitOfWork>();

            return container;
        }
    }
}