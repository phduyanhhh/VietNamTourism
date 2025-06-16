using Abp.AspNetCore.Mvc.Views;
using Abp.Localization.Sources;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.Localization;

namespace VietNamTourism.Web.Views;

public abstract class VietNamTourismRazorPage<TModel> : AbpRazorPage<TModel>
{
	[RazorInject]
	public IAbpSession AbpSession { get; set; }

	protected VietNamTourismRazorPage()
	{
		LocalizationSourceName = VietNamTourismConsts.LocalizationSourceName;
	}
}
