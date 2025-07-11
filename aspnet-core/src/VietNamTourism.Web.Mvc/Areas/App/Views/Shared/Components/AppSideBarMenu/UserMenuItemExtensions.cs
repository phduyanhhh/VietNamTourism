﻿using Abp.Application.Navigation;
using System.Collections.Generic;
using System.Linq;

namespace VietNamTourism.Web.Areas.App.Views.Shared.Components.AppSideBarMenu
{
	public static class UserMenuItemExtensions
	{
		public static IOrderedEnumerable<UserMenuItem> OrderByCustom(this IEnumerable<UserMenuItem> menuItems)
		{
			return menuItems
					.OrderBy(menuItem => menuItem.Order)
					.ThenBy(menuItem => menuItem.DisplayName);
		}
	}
}
