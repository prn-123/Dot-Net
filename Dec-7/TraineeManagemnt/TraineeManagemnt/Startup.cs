using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TraineeManagemnt.Startup))]
namespace TraineeManagemnt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
