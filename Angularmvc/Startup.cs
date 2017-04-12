using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Angularmvc.Startup))]
namespace Angularmvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
