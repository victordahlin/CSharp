using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Booking_system.Startup))]
namespace Booking_system
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
