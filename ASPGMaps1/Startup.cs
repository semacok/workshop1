using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPGMaps1.Startup))]
namespace ASPGMaps1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
