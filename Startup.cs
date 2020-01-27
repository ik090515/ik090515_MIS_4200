using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ik090515_MIS4200.Startup))]
namespace ik090515_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
