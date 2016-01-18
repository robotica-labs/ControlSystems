using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControlSystems.Startup))]
namespace ControlSystems
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
