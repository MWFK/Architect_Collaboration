using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ParcelleWeb.Startup))]
namespace ParcelleWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
