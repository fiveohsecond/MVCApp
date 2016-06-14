using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Martin.Web.Startup))]
namespace Martin.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
