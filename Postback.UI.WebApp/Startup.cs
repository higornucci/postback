using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Postback.UI.WebApp.Startup))]
namespace Postback.UI.WebApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}