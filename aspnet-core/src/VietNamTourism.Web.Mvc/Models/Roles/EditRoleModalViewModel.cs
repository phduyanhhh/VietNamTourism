using Abp.AutoMapper;
using VietNamTourism.Roles.Dto;
using VietNamTourism.Web.Models.Common;

namespace VietNamTourism.Web.Models.Roles;

[AutoMapFrom(typeof(GetRoleForEditOutput))]
public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
{
    public bool HasPermission(FlatPermissionDto permission)
    {
        return GrantedPermissionNames.Contains(permission.Name);
    }
}
