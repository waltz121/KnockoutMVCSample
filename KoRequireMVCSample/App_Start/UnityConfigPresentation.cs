using KoRequireMVCSample.Controllers;
using KoRequireMVCSample.Factory;
using KoRequireMVCSample.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.Mvc5;

namespace KoRequireMVCSample.App_Start
{
    public static class UnityConfigPresentation
    {
        public static void RegisterComponents(UnityContainer container)
        {
            container.RegisterType<IProductTypeViewModelFactory, ProductTypeViewModelFactory>();
            container.RegisterType<IProductViewModelFactory, ProductViewModelFactory>();

            container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>();
            container.RegisterType<UserManager<ApplicationUser>>();
            container.RegisterType<DbContext, ApplicationDbContext>();
            container.RegisterType<ApplicationUserManager>();
            container.RegisterType<AccountController>(new InjectionConstructor());

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}