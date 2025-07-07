using System;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using VietNamTourism.Controllers;
using VietNamTourism.Entities;
using VietNamTourism.Services.ProvincesAppService;
using VietNamTourism.Web.Areas.Tms.Models.Provinces;

namespace VietNamTourism.Web.Areas.Tms.Controllers
{
	[Area("Tms")]
	[AbpMvcAuthorize]
	public class ProvincesController : VietNamTourismControllerBase
	{
		private readonly IProvincesAppService _provincesAppService;
		public ProvincesController(
			IProvincesAppService provincesAppService
		)
		{
			_provincesAppService = provincesAppService;
		}

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
		public async Task<IActionResult> EditModal(int id)
		{
			var modal = new ProvincesViewModal
			{
				Province = await _provincesAppService.GetAnProvince(id),
			};
			ViewBag.RegionList = Enum.GetValues(typeof(RegionEnum))
				.Cast<RegionEnum>()
				.Select(e => new SelectListItem
				{
					Value = ((int)e).ToString(),
					Text = e.ToString(),
					Selected = modal.Province.Region.HasValue && modal.Province.Region.Value == e
				})
				.ToList();
			return PartialView("_EditModal", modal);
		}
	}
}
