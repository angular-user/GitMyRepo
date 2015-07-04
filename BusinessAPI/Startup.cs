using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BusinessAPI.Startup))]
namespace BusinessAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
