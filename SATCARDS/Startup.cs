using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SATCARDS.Startup))]
namespace SATCARDS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
