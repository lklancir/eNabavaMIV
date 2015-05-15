using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eNabava_MIV.Startup))]
namespace eNabava_MIV
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
