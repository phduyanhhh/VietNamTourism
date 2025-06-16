using Abp.AspNetCore.Mvc.ViewComponents;

namespace VietNamTourism.Web.Views;

public abstract class VietNamTourismViewComponent : AbpViewComponent
{
    protected VietNamTourismViewComponent()
    {
        LocalizationSourceName = VietNamTourismConsts.LocalizationSourceName;
    }
}
