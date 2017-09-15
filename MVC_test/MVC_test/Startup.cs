using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_test.Startup))]
namespace MVC_test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
