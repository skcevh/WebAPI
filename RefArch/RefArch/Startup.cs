using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RefArch.Startup))]
namespace RefArch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
