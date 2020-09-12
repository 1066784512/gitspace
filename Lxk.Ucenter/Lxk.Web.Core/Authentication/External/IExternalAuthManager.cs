using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lxk.Ucenter.Web.Core.Authentication.External
{
    public interface IExternalAuthManager
    {
        Task<bool> IsValidUser(string provider, string providerKey, string providerAccessCode);

        Task<ExternalAuthUserInfo> GetUserInfo(string provider, string accessCode);
    }
}
