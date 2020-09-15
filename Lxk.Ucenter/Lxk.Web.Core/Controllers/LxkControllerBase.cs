using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Lxk.Core;
using Microsoft.AspNetCore.Identity;

namespace Lxk.Ucenter.Web.Core.Controllers
{
    public abstract class LxkControllerBase : AbpController
    {
        protected LxkControllerBase()
        {
            LocalizationSourceName = AppConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
