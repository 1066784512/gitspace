using Abp.Authorization;
using Lxk.Ucenter.Core.Authorization.Roles;
using Lxk.Ucenter.Core.Authorization.Users;

namespace Lxk.Ucenter.Core.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
