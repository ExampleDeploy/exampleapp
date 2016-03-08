using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AWSTest.Startup))]
namespace AWSTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
