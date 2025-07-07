using Abp.Application.Navigation;
using Abp.Authorization;
using Abp.Localization;
using VietNamTourism.Authorization;

namespace VietNamTourism.Web.Startup;

/// <summary>
/// This class defines menus for the application.
/// </summary>
public class VietNamTourismNavigationProvider : NavigationProvider
{
	public const string MenuName = "Administrators";
	public override void SetNavigation(INavigationProviderContext context)
	{
		context.Manager.MainMenu
				.AddItem(
						new MenuItemDefinition(
								PageNames.About,
								L("About"),
								url: "About",
								icon: "fas fa-info-circle"
						)
				)
				.AddItem(
						new MenuItemDefinition(
								PageNames.Dashboard,
								L("Dashboard"),
								url: "/Tms/Dashboard",
								icon: "fas fa-home",
								requiresAuthentication: true
						)
				)
				.AddItem(
						new MenuItemDefinition(
								PageNames.Provinces,
								L("Provinces"),
								url: "/Tms/Provinces",
								icon: "fas fa-city",
								requiresAuthentication: true
						)
				)
				.AddItem(
						new MenuItemDefinition(
								PageNames.Administration,
								L("Administration"),
								icon: "fas fa-cogs"
						//permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Roles)
						).AddItem(
							new MenuItemDefinition(
									PageNames.Roles,
									L("Roles"),
									url: "Roles",
									icon: "fas fa-theater-masks",
									permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Roles)
							)
						).AddItem(
							new MenuItemDefinition(
								PageNames.Tenants,
								L("Tenants"),
								url: "Tenants",
								icon: "fas fa-building",
								permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Tenants)
							)
						).AddItem(
							new MenuItemDefinition(
								PageNames.Users,
								L("Users"),
								url: "Users",
								icon: "fas fa-users",
								permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Users)
							)
						).AddItem(
							new MenuItemDefinition(
								PageNames.Languages,
								L("Languages"),
								url: "Languages",
								icon: "fas fa-language",
								permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Users)
							)
						)
				);

	}

	private static ILocalizableString L(string name)
	{
		return new LocalizableString(name, VietNamTourismConsts.LocalizationSourceName);
	}
}