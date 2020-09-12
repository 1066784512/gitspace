using System;
using System.Collections.Generic;
using System.Text;

namespace Lxk.Ucenter.Web.Core.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
