using Abp.Configuration.Startup;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VietNamTourism.Sessions;
using VietNamTourism.Web.Views;

namespace VietNamTourism.Web.Areas.App.Views.Shared.Components.AppSideBarUserArea
{
	public class AppSideBarUserAreaViewComponent : VietNamTourismViewComponent 
	{
		private readonly ISessionAppService _sessionAppService;
		private readonly IMultiTenancyConfig _multiTenancyConfig;

		public AppSideBarUserAreaViewComponent(
						ISessionAppService sessionAppService,
						IMultiTenancyConfig multiTenancyConfig)
		{
			_sessionAppService = sessionAppService;
			_multiTenancyConfig = multiTenancyConfig;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var model = new AppSideBarUserAreaViewModel
			{
				LoginInformations = await _sessionAppService.GetCurrentLoginInformations(),
				IsMultiTenancyEnabled = _multiTenancyConfig.IsEnabled,
			};
			//return View(model);
			return View("~/Areas/App/Views/Shared/Components/AppSideBarUserArea/Default.cshtml", model);
		}
	}
}
