using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Show_country_DropDownApp.Startup))]
namespace Show_country_DropDownApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
