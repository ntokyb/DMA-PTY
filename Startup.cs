using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DMA__Pty__Ltd.Startup))]
namespace DMA__Pty__Ltd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
