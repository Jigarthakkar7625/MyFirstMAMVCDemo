using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFirstMAMVCDemo.Startup))]
namespace MyFirstMAMVCDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
