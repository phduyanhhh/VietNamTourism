using Abp.Application.Services;
using VietNamTourism.Authorization.Accounts.Dto;
using System.Threading.Tasks;

namespace VietNamTourism.Authorization.Accounts;

public interface IAccountAppService : IApplicationService
{
    Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

    Task<RegisterOutput> Register(RegisterInput input);
}
