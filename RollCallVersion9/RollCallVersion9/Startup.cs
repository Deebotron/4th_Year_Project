using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RollCallVersion9.Startup))]
namespace RollCallVersion9
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
