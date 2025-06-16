using Abp.Modules;
using Abp.Reflection.Extensions;
using VietNamTourism.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace VietNamTourism.Web.Startup;

[DependsOn(typeof(VietNamTourismWebCoreModule))]
public class VietNamTourismWebMvcModule : AbpModule
{
    private readonly IWebHostEnvironment _env;
    private readonly IConfigurationRoot _appConfiguration;

    public VietNamTourismWebMvcModule(IWebHostEnvironment env)
    {
        _env = env;
        _appConfiguration = env.GetAppConfiguration();
    }

    public override void PreInitialize()
    {
        Configuration.Navigation.Providers.Add<VietNamTourismNavigationProvider>();
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(VietNamTourismWebMvcModule).GetAssembly());
    }
}
