using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly5.Startup))]
namespace Vidly5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
