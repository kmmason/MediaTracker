using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MediaTracker.Startup))]
namespace MediaTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
