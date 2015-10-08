using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ATM1.Startup))]
namespace ATM1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
