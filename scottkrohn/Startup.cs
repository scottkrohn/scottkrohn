using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(scottkrohn.Startup))]
namespace scottkrohn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
