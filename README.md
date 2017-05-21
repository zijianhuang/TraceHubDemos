# TraceHub Demos

While TraceHub has already offerred TraceHub MVC and TraceHub Slim which you may deploy directly, you may also incooperate core functionalities of TraceHub into your existing Webistes or services.


# Your TraceHub Slim

Steps:
1. Import NuGet package Fonlow.TraceHub.Slim to your ASP.NET Web project.
2. Add the code snippet similar to the one below to Startup.cs

```c#
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TraceHubSlimDemo.MySignalRStartup))]
namespace TraceHubSlimDemo
{
    public partial class MySignalRStartup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
```

3. Build and deploy your project, then you could access TraceHub Slim at something like http://YourProject.com/logging.html

#
