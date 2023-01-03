using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ERP_CRM.Startup))]
namespace ERP_CRM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
