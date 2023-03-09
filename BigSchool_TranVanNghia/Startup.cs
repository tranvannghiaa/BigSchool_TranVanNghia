using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigSchool_TranVanNghia.Startup))]
namespace BigSchool_TranVanNghia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
