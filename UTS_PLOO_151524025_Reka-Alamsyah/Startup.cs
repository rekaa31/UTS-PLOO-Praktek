using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UTS_PLOO_151524025_Reka_Alamsyah.Startup))]
namespace UTS_PLOO_151524025_Reka_Alamsyah
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
