using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TraceHubMvcWebApi.Startup))]
namespace TraceHubMvcWebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
