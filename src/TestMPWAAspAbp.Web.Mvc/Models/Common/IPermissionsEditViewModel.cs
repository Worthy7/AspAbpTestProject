using System.Collections.Generic;
using TestMPWAAspAbp.Roles.Dto;

namespace TestMPWAAspAbp.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}