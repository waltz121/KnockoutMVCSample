using KnockoutMVCApplication.Product.GetListProductsQuery;
using KnockoutMVCApplication.ProductType.GetListOfProductTypesQuery;
using KnockoutMVCCommons.HttpRequest.RequestGet;
using KnockoutMVCCommons.HttpRequest.RequestPost;
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
            container.RegisterType<IGetListOfProductTypesQuery, GetListOfProductTypesQuery>();
            container.RegisterType<IGetListProductsQuery, GetListProductsQuery>();
            container.RegisterType<IHttpRequestGet, HttpRequestGet>();
            container.RegisterType<IHttpRequestPost, HttpRequestPost>();

            return container;
        }
    }
}