using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorkAndTravelUSA.Startup))]
namespace WorkAndTravelUSA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
