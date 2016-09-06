using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GetARoom.UI.Web.Administration.Startup))]
namespace GetARoom.UI.Web.Administration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
