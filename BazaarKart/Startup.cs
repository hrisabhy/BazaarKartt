using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BazaarKart.Startup))]
namespace BazaarKart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
