using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GithubTest.Startup))]
namespace GithubTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
