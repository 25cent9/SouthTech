using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TextWebService.Startup))]
namespace TextWebService
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
