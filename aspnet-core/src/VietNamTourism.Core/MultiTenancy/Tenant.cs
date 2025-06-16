using Abp.MultiTenancy;
using VietNamTourism.Authorization.Users;

namespace VietNamTourism.MultiTenancy;

public class Tenant : AbpTenant<User>
{
    public Tenant()
    {
    }

    public Tenant(string tenancyName, string name)
        : base(tenancyName, name)
    {
    }
}
