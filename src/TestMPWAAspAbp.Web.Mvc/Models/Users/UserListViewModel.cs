using System.Collections.Generic;
using TestMPWAAspAbp.Roles.Dto;
using TestMPWAAspAbp.Users.Dto;

namespace TestMPWAAspAbp.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
