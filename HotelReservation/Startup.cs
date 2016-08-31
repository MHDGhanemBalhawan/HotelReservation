using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HotelReservation.Startup))]
namespace HotelReservation
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
