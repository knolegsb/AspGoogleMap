using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspGoogleMap.Startup))]
namespace AspGoogleMap
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
