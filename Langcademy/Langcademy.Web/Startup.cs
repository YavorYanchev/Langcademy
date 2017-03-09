using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Langcademy.Web.Startup))]
namespace Langcademy.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
