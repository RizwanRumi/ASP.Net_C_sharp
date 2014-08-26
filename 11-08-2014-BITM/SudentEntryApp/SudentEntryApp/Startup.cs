using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SudentEntryApp.Startup))]
namespace SudentEntryApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
