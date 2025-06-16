using Abp.Application.Services;
using VietNamTourism.Sessions.Dto;
using System.Threading.Tasks;

namespace VietNamTourism.Sessions;

public interface ISessionAppService : IApplicationService
{
    Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
}
