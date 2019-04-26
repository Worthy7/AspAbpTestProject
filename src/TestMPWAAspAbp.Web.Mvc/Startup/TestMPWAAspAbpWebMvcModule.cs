using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TestMPWAAspAbp.Configuration;

namespace TestMPWAAspAbp.Web.Startup
{
    [DependsOn(typeof(TestMPWAAspAbpWebCoreModule))]
    public class TestMPWAAspAbpWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TestMPWAAspAbpWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<TestMPWAAspAbpNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TestMPWAAspAbpWebMvcModule).GetAssembly());
        }
    }
}
