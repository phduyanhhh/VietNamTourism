using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using VietNamTourism.Controllers;

namespace VietNamTourism.Web.Areas.Tms.Controllers
{
	[Area("Tms")]
	[AbpMvcAuthorize]
	public class DashboardController : VietNamTourismControllerBase
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
