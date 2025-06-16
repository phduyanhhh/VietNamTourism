using Abp.Modules;
using Abp.Reflection.Extensions;
using VietNamTourism.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace VietNamTourism.Web.Host.Startup
{
    [DependsOn(
       typeof(VietNamTourismWebCoreModule))]
    public class VietNamTourismWebHostModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public VietNamTourismWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VietNamTourismWebHostModule).GetAssembly());
        }
    }
}
