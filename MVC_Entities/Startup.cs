using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Entities.Startup))]
namespace MVC_Entities
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
