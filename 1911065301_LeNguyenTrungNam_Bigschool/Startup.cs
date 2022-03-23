using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1911065301_LeNguyenTrungNam_Bigschool.Startup))]
namespace _1911065301_LeNguyenTrungNam_Bigschool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
