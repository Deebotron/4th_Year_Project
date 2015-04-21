using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RollCallV8.Startup))]
namespace RollCallV8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
