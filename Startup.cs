using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab456.Startup))]
namespace Lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
