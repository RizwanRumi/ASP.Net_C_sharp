using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcCountryCityWeb.Startup))]
namespace MvcCountryCityWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
