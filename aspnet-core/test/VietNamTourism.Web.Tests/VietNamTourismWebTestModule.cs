using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using VietNamTourism.EntityFrameworkCore;
using VietNamTourism.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace VietNamTourism.Web.Tests;

[DependsOn(
    typeof(VietNamTourismWebMvcModule),
    typeof(AbpAspNetCoreTestBaseModule)
)]
public class VietNamTourismWebTestModule : AbpModule
{
    public VietNamTourismWebTestModule(VietNamTourismEntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
    }

    public override void PreInitialize()
    {
        Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(VietNamTourismWebTestModule).GetAssembly());
    }

    public override void PostInitialize()
    {
        IocManager.Resolve<ApplicationPartManager>()
            .AddApplicationPartsIfNotAddedBefore(typeof(VietNamTourismWebMvcModule).Assembly);
    }
}