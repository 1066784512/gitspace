﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lxk.Ucenter.Web.Core.Models.TokenAuth
{
    public class AuthenticateResultModel
    {
        public string AccessToken { get; set; }

        public string EncryptedAccessToken { get; set; }

        public int ExpireInSeconds { get; set; }

        public long UserId { get; set; }
    }
}