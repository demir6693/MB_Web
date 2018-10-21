using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MB_Web.Startup))]
namespace MB_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
