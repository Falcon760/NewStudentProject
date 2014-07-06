using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewStudentProject.Startup))]
namespace NewStudentProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
