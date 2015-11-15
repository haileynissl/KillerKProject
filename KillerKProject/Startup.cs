using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KillerKProject.Startup))]
namespace KillerKProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
