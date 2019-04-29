using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PeerTutor.Startup))]
namespace PeerTutor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
