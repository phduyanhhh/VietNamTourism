﻿using VietNamTourism.Sessions.Dto;

namespace VietNamTourism.Web.Areas.App.Views.Shared.Components.AppSideBarUserArea
{
	public class AppSideBarUserAreaViewModel
	{
		public GetCurrentLoginInformationsOutput LoginInformations { get; set; }

		public bool IsMultiTenancyEnabled { get; set; }

		public string GetShownLoginName()
		{
			var userName = LoginInformations.User.UserName;

			if (!IsMultiTenancyEnabled)
			{
				return userName;
			}

			return LoginInformations.Tenant == null
					? ".\\" + userName
					: LoginInformations.Tenant.TenancyName + "\\" + userName;
		}
	}
}
