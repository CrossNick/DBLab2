using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DBLab2.UI.Startup))]
namespace DBLab2.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
