using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeptStudentApp.Startup))]
namespace DeptStudentApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
