using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCDALWebAPi.Startup))]
namespace MVCDALWebAPi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
