using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc03.Startup))]
namespace mvc03
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
