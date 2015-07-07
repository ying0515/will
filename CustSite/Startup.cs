using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustSite.Startup))]
namespace CustSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
