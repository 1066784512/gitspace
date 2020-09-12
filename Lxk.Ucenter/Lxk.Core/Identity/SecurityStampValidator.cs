using Abp.Authorization;
using Microsoft.Extensions.Logging;
using Lxk.Ucenter.Core.Authorization.Roles;
using Lxk.Ucenter.Core.Authorization.Users;
using Lxk.Ucenter.Core.MultiTenancy;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace Lxk.Ucenter.Core.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options,
            SignInManager signInManager,
            ISystemClock systemClock,
            ILoggerFactory loggerFactory)
            : base(options, signInManager, systemClock, loggerFactory)
        {
        }
    }
}
