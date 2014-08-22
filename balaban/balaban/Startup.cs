using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(balaban.Startup))]
namespace balaban
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
