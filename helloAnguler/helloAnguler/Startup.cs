using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(helloAnguler.Startup))]
namespace helloAnguler
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
