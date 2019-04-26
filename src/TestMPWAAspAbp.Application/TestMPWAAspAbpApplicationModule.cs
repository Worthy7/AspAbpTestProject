using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TestMPWAAspAbp.Authorization;

namespace TestMPWAAspAbp
{
    [DependsOn(
        typeof(TestMPWAAspAbpCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TestMPWAAspAbpApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TestMPWAAspAbpAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TestMPWAAspAbpApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
