using System;
using System.Collections.Generic;
using System.Text;

namespace Lxk.Ucenter.Web.Core.Authentication.External
{
    public class ExternalAuthUserInfo
    {
        public string ProviderKey { get; set; }

        public string Name { get; set; }

        public string EmailAddress { get; set; }

        public string Surname { get; set; }

        public string Provider { get; set; }
    }
}
