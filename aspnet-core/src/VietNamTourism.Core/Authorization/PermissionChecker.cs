using Abp.Authorization;
using VietNamTourism.Authorization.Roles;
using VietNamTourism.Authorization.Users;

namespace VietNamTourism.Authorization;

public class PermissionChecker : PermissionChecker<Role, User>
{
    public PermissionChecker(UserManager userManager)
        : base(userManager)
    {
    }
}
