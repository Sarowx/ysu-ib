using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YSUIB.Startup))]
namespace YSUIB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
