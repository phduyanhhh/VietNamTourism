using VietNamTourism.Roles.Dto;
using System.Collections.Generic;

namespace VietNamTourism.Web.Models.Users;

public class UserListViewModel
{
    public IReadOnlyList<RoleDto> Roles { get; set; }
}
