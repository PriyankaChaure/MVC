using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Actionfilter_authorize_allowanonymous.Startup))]
namespace Actionfilter_authorize_allowanonymous
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
