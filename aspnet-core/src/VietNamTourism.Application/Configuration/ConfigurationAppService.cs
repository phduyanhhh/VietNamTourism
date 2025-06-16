using Abp.Authorization;
using Abp.Runtime.Session;
using VietNamTourism.Configuration.Dto;
using System.Threading.Tasks;

namespace VietNamTourism.Configuration;

[AbpAuthorize]
public class ConfigurationAppService : VietNamTourismAppServiceBase, IConfigurationAppService
{
    public async Task ChangeUiTheme(ChangeUiThemeInput input)
    {
        await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
    }
}
