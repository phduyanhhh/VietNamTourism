﻿using Abp.Application.Navigation;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VietNamTourism.Controllers;
using VietNamTourism.Web.Views;
using VietNamTourism.Web.Views.Shared.Components.SideBarMenu;

namespace VietNamTourism.Web.Areas.App.Views.Shared.Components.AppSideBarMenu
{
	public class AppSideBarMenuViewComponent : VietNamTourismViewComponent
	{
		private readonly IUserNavigationManager _userNavigationManager;
		private readonly IAbpSession _abpSession;

		public AppSideBarMenuViewComponent(
				IUserNavigationManager userNavigationManager,
				IAbpSession abpSession)
		{
			_userNavigationManager = userNavigationManager;
			_abpSession = abpSession;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var model = new AppSideBarMenuModel
			{
				MainMenu = await _userNavigationManager.GetMenuAsync("MainMenu", _abpSession.ToUserIdentifier())
			};

			//return View(model);
			return View("~/Areas/App/Views/Shared/Components/AppSideBarMenu/Default.cshtml", model);

		}
	}
}
