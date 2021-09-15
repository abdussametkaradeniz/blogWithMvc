using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(B403Blog.Startup))]
namespace B403Blog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
