using VietNamTourism.Roles.Dto;
using System.Collections.Generic;

namespace VietNamTourism.Web.Models.Roles;

public class RoleListViewModel
{
    public IReadOnlyList<PermissionDto> Permissions { get; set; }
}
