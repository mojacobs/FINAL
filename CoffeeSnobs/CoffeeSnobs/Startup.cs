using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoffeeSnobs.Startup))]
namespace CoffeeSnobs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
