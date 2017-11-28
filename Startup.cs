using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(angular_cascading.Startup))]
namespace angular_cascading
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
