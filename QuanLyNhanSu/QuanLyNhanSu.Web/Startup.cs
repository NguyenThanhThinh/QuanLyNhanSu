using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuanLyNhanSu.Web.Startup))]
namespace QuanLyNhanSu.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
