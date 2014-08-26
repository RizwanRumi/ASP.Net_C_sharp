using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspDropdownTestApp.Startup))]
namespace AspDropdownTestApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
