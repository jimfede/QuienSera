using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuienSera.Startup))]
namespace QuienSera
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
