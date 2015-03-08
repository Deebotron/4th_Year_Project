using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Role_call.Startup))]
namespace Role_call
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
