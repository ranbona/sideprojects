using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstWebDOTNET.Startup))]
namespace FirstWebDOTNET
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
