using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bar.Startup))]
namespace Bar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
