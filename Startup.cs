using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PureFullIdentity.Startup))]
namespace PureFullIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
