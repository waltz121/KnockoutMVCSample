using KnockoutMVCSample.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace KnockoutMVCSample.App_Start
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