using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartTeleHealth.Web.Startup))]
namespace SmartTeleHealth.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
