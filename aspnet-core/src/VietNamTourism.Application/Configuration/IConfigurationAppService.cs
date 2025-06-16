using VietNamTourism.Configuration.Dto;
using System.Threading.Tasks;

namespace VietNamTourism.Configuration;

public interface IConfigurationAppService
{
    Task ChangeUiTheme(ChangeUiThemeInput input);
}
