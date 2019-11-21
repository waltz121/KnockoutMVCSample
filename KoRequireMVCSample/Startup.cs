using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KoRequireMVCSample.Startup))]
namespace KoRequireMVCSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
