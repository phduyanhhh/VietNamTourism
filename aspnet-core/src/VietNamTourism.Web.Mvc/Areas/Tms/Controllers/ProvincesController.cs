using System;
using System.Linq;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using VietNamTourism.Controllers;
using VietNamTourism.Entities;

namespace VietNamTourism.Web.Areas.Tms.Controllers
{
	[Area("Tms")]
	[AbpMvcAuthorize]
	public class ProvincesController : VietNamTourismControllerBase
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult CreateModal()
		{
			ViewBag.RegionList = new SelectList(Enum.GetValues(typeof(RegionEnum))
				.Cast<RegionEnum>()
				.Select(e => new { Id = (int)e, Name = e.ToString() }), "Id", "Name"
				);
			return PartialView("_CreateModal");
		}
	}
}
