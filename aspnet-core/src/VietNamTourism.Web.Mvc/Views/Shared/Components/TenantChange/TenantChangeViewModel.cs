using Abp.AutoMapper;
using VietNamTourism.Sessions.Dto;

namespace VietNamTourism.Web.Views.Shared.Components.TenantChange;

[AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
public class TenantChangeViewModel
{
    public TenantLoginInfoDto Tenant { get; set; }
}
