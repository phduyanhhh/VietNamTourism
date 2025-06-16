using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using VietNamTourism.Authorization;

namespace VietNamTourism;

[DependsOn(
    typeof(VietNamTourismCoreModule),
    typeof(AbpAutoMapperModule))]
public class VietNamTourismApplicationModule : AbpModule
{
    public override void PreInitialize()
    {
        Configuration.Authorization.Providers.Add<VietNamTourismAuthorizationProvider>();
    }

    public override void Initialize()
    {
        var thisAssembly = typeof(VietNamTourismApplicationModule).GetAssembly();

        IocManager.RegisterAssemblyByConvention(thisAssembly);

        Configuration.Modules.AbpAutoMapper().Configurators.Add(
            // Scan the assembly for classes which inherit from AutoMapper.Profile
            cfg => cfg.AddMaps(thisAssembly)
        );
    }
}
