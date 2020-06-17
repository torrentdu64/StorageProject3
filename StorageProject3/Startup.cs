using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StorageProject3.Startup))]
namespace StorageProject3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
