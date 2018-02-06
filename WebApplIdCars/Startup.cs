using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplIdCars.Startup))]
namespace WebApplIdCars
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
