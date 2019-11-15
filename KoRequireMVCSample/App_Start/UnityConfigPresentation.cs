using KoRequireMVCSample.Factory;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace KoRequireMVCSample.App_Start
{
    public static class UnityConfigPresentation
    {
        public static void RegisterComponents(UnityContainer container)
        {
            container.RegisterType<IProductTypeViewModelFactory, ProductTypeViewModelFactory>();
            container.RegisterType<IProductViewModelFactory, ProductViewModelFactory>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}