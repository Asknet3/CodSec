using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodSec.Startup))]
namespace CodSec
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
