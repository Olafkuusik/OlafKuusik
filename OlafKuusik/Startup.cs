using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OlafKuusik.Startup))]
namespace OlafKuusik
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
