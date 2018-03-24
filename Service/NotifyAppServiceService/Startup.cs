using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(NotifyAppServiceService.Startup))]

namespace NotifyAppServiceService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}