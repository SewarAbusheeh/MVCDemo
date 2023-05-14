using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcDemoAuth.Startup))]
namespace MvcDemoAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
