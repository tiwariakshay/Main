using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContentManagment.Startup))]
namespace ContentManagment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
