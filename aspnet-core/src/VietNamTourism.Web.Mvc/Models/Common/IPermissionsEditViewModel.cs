using VietNamTourism.Roles.Dto;
using System.Collections.Generic;

namespace VietNamTourism.Web.Models.Common;

public interface IPermissionsEditViewModel
{
    List<FlatPermissionDto> Permissions { get; set; }
}