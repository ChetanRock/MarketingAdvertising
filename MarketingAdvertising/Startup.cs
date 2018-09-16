using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarketingAdvertising.Startup))]
namespace MarketingAdvertising
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
