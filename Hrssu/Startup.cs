using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hrssu.Startup))]
namespace Hrssu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
