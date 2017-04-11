using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleProject_1.Startup))]
namespace SampleProject_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
