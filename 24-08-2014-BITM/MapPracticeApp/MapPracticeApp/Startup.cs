using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MapPracticeApp.Startup))]
namespace MapPracticeApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
