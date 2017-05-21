using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TraceHubMvcDemo.Startup))]
namespace TraceHubMvcDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            app.MapSignalR();

        }
    }
}
