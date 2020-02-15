using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HappyPub.Startup))]
namespace HappyPub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
