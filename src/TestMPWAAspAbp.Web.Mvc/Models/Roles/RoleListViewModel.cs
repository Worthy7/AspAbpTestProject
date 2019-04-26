using System.Collections.Generic;
using TestMPWAAspAbp.Roles.Dto;

namespace TestMPWAAspAbp.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
