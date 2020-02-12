using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GiveAidProject.Startup))]
namespace GiveAidProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
