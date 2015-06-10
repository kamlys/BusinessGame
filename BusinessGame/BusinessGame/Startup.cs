using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BusinessGame.Startup))]
namespace BusinessGame
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
