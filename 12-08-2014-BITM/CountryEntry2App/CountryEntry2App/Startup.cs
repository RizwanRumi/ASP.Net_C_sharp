using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CountryEntry2App.Startup))]
namespace CountryEntry2App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
