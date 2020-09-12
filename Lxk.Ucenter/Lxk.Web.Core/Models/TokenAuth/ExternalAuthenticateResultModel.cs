using System;
using System.Collections.Generic;
using System.Text;

namespace Lxk.Ucenter.Web.Core.Models.TokenAuth
{
    public class ExternalAuthenticateResultModel
    {
        public string AccessToken { get; set; }

        public string EncryptedAccessToken { get; set; }

        public int ExpireInSeconds { get; set; }

        public bool WaitingForActivation { get; set; }
    }
}
