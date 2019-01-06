using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SanjayMsBuildCI.Startup))]
namespace SanjayMsBuildCI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
