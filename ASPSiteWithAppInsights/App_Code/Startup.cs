using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPSiteWithAppInsights.Startup))]
namespace ASPSiteWithAppInsights
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
