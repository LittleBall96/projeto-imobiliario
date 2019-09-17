using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ImobiliariaWeb.Startup))]
namespace ImobiliariaWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
