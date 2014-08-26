using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CountryCityMgmtMVCApp.Startup))]
namespace CountryCityMgmtMVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
