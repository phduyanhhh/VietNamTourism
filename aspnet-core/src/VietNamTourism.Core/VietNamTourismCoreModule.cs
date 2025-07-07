using Abp.Localization;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Runtime.Security;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using VietNamTourism.Authorization.Roles;
using VietNamTourism.Authorization.Users;
using VietNamTourism.Configuration;
using VietNamTourism.Localization;
using VietNamTourism.MultiTenancy;
using VietNamTourism.Timing;

namespace VietNamTourism;

[DependsOn(typeof(AbpZeroCoreModule))]
public class VietNamTourismCoreModule : AbpModule
{
	public override void PreInitialize()
	{
		Configuration.Auditing.IsEnabledForAnonymousUsers = true;

		// Declare entity types
		Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
		Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
		Configuration.Modules.Zero().EntityTypes.User = typeof(User);

		VietNamTourismLocalizationConfigurer.Configure(Configuration.Localization);

		// Enable this line to create a multi-tenant application.
		Configuration.MultiTenancy.IsEnabled = VietNamTourismConsts.MultiTenancyEnabled;

		// Configure roles
		AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

		Configuration.Settings.Providers.Add<AppSettingProvider>();

		//Configuration.Localization.Languages.Add(new LanguageInfo("fa", "فارسی", "famfamfam-flags ir"));
		// Đăng ký ngôn ngữ hỗ trợ
		Configuration.Localization.Languages.Add(new LanguageInfo("vi", "Tiếng Việt", "famfamfam-flags vi", isDefault: true));
		Configuration.Localization.Languages.Add(new LanguageInfo("en", "English", "famfamfam-flags gb"));


		Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = VietNamTourismConsts.DefaultPassPhrase;
		SimpleStringCipher.DefaultPassPhrase = VietNamTourismConsts.DefaultPassPhrase;
	}

	public override void Initialize()
	{
		IocManager.RegisterAssemblyByConvention(typeof(VietNamTourismCoreModule).GetAssembly());
	}

	public override void PostInitialize()
	{
		IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
	}
}
