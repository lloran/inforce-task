using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(InForceWebApp.StartupOwin))]

namespace InForceWebApp
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
