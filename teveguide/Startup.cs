using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(teveguide.Startup))]
namespace teveguide
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
