using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoolsFriend.Startup))]
namespace SchoolsFriend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
