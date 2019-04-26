using Abp.Authorization;
using TestMPWAAspAbp.Authorization.Roles;
using TestMPWAAspAbp.Authorization.Users;

namespace TestMPWAAspAbp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
