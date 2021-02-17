using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Oridey.Startup))]

namespace Oridey
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}