using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mini_E_Pay.Startup))]
namespace Mini_E_Pay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
