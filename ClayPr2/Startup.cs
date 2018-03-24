using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClayPr2.Startup))]
namespace ClayPr2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
