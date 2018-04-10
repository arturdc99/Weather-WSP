using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeatherFront.Startup))]
namespace WeatherFront
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
