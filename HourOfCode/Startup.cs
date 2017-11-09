using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HourOfCode.Startup))]
namespace HourOfCode
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
