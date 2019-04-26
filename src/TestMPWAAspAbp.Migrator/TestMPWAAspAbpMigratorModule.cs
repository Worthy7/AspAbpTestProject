using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TestMPWAAspAbp.Configuration;
using TestMPWAAspAbp.EntityFrameworkCore;
using TestMPWAAspAbp.Migrator.DependencyInjection;

namespace TestMPWAAspAbp.Migrator
{
    [DependsOn(typeof(TestMPWAAspAbpEntityFrameworkModule))]
    public class TestMPWAAspAbpMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public TestMPWAAspAbpMigratorModule(TestMPWAAspAbpEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(TestMPWAAspAbpMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                TestMPWAAspAbpConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TestMPWAAspAbpMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
