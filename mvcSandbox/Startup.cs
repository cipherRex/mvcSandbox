using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcSandbox.Startup))]
namespace mvcSandbox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
