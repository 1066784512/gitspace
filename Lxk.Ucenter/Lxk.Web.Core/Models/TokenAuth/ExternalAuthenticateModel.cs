using Abp.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lxk.Ucenter.Web.Core.Models.TokenAuth
{
    public class ExternalAuthenticateModel
    {
        [Required]
        [StringLength(UserLogin.MaxLoginProviderLength)]
        public string AuthProvider { get; set; }

        [Required]
        [StringLength(UserLogin.MaxProviderKeyLength)]
        public string ProviderKey { get; set; }

        [Required]
        public string ProviderAccessCode { get; set; }
    }
}
