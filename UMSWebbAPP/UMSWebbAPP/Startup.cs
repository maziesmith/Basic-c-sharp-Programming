using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UMSWebbAPP.Startup))]
namespace UMSWebbAPP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
