# TraceHub Demos

While TraceHub has already offerred TraceHub MVC and TraceHub Slim which you may build and deploy directly, you may also incooperate core functionalities of TraceHub into your existing Webistes or services.

Ths repostory was constructed through the followng descrptons.


## Your TraceHub Slim -- TraceHubSlimDemo.csproj

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


## App that writes traces to TraceHub Slim -- TestTraceListener.csproj

Steps:
1. Import NuGet Fonlow.HubTraceListener to your app.
2. Modify app.config/web.config to inject the listener.

## References

1. [TraceHub Wiki](https://github.com/zijianhuang/TraceHub/wiki)
2. [TraceHub Tutorial](https://www.codeproject.com/Articles/1118166/TraceHub-a-flexible-solution-for-Web-based-structu)


# WCF Service and TraceHub Demo

A more complex demo is persisted in [another repository](github.com/zijianhuang/HelloWorldAuth/tree/branches/TraceHub). This demo is based on article [WCF for the Real World, Not Hello World, Part II](https://www.codeproject.com/Articles/1130178/WCF-for-the-Real-World-Not-Hello-World-Part-II). 

So there's already a WCF Web service. Now you want to log remotely. 

Steps:
1. Import NuGet Fonlow.HubTraceListener to your app.
2. Modify web.config to inject the listener.

Have a look at web.config, you will see the beauty of using System.Diagnostics compatible technologies: the traces emitted by trace sources in .NET Frameworks could be easily viewable in TraceHub.


In addition to your favoriate way of running multiple applications during development, here's an alternative way:
1. In the properties pans of both Web projects, turn "Always Start When Debugging" to false; and ensure both sites are not launched by IDE. If they are already running as found in the IIS Express trayicon, shut them down.  
1. Run StartWcfService1.ps1 and StartTraceHubSlim.ps1 in the root folder. And launch a Web browser to view http://localhost:30510/logging.html
1. Run the integration tests.

You will see a lot trace messages appearing in the Web page.