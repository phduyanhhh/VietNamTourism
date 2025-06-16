using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace VietNamTourism.Controllers
{
    public abstract class VietNamTourismControllerBase : AbpController
    {
        protected VietNamTourismControllerBase()
        {
            LocalizationSourceName = VietNamTourismConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
