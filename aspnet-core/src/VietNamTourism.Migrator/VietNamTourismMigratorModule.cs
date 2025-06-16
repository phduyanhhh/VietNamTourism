using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using VietNamTourism.Configuration;
using VietNamTourism.EntityFrameworkCore;
using VietNamTourism.Migrator.DependencyInjection;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;

namespace VietNamTourism.Migrator;

[DependsOn(typeof(VietNamTourismEntityFrameworkModule))]
public class VietNamTourismMigratorModule : AbpModule
{
    private readonly IConfigurationRoot _appConfiguration;

    public VietNamTourismMigratorModule(VietNamTourismEntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

        _appConfiguration = AppConfigurations.Get(
            typeof(VietNamTourismMigratorModule).GetAssembly().GetDirectoryPathOrNull()
        );
    }

    public override void PreInitialize()
    {
        Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
            VietNamTourismConsts.ConnectionStringName
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
        IocManager.RegisterAssemblyByConvention(typeof(VietNamTourismMigratorModule).GetAssembly());
        ServiceCollectionRegistrar.Register(IocManager);
    }
}
