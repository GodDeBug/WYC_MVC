using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(wyc_MVC.Startup))]
namespace wyc_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
