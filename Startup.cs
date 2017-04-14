using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DA_THPT.Startup))]
namespace DA_THPT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
