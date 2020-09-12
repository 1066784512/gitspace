using Abp.AutoMapper;
using Lxk.Ucenter.Web.Core.Authentication.External;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lxk.Ucenter.Web.Core.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
