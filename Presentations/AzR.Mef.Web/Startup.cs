using AzR.Web.Root.MEF;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzR.Mef.Web.Startup))]
namespace AzR.Mef.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            AzRAppRegister.Register();

        }
    }
}
