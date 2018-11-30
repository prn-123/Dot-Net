using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFcodeFirstIdentity.Startup))]
namespace EFcodeFirstIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
