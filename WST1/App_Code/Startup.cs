using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WST1.Startup))]
namespace WST1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
