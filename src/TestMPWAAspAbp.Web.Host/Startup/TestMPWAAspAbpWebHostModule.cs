using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TestMPWAAspAbp.Configuration;

namespace TestMPWAAspAbp.Web.Host.Startup
{
    [DependsOn(
       typeof(TestMPWAAspAbpWebCoreModule))]
    public class TestMPWAAspAbpWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TestMPWAAspAbpWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TestMPWAAspAbpWebHostModule).GetAssembly());
        }
    }
}
