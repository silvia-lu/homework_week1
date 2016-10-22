using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(homework_week1.Startup))]
namespace homework_week1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
