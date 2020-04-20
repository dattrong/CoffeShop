using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Coffeeshop.Startup))]
namespace Coffeeshop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
