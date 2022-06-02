using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeDinhPhuc_BigSchool.Startup))]
namespace LeDinhPhuc_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
