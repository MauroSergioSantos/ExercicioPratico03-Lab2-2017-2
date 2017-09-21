using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp_ExercicioPratico03_Lab2_2017_2.Startup))]
namespace WebApp_ExercicioPratico03_Lab2_2017_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
