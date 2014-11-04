using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstCareFit.Web.Startup))]
namespace FirstCareFit.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
