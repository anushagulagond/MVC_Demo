using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TaskMgntWebApplication.Startup))]
namespace TaskMgntWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
