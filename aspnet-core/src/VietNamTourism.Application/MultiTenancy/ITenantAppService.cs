using Abp.Application.Services;
using VietNamTourism.MultiTenancy.Dto;

namespace VietNamTourism.MultiTenancy;

public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
{
}

