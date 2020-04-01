using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Turntabl.RoleService.Startup))]
namespace Turntabl.RoleService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
