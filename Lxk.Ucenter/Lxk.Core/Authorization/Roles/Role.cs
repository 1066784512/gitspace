﻿using Abp.Authorization.Roles;
using Lxk.Ucenter.Core.Authorization.Users;
using System.ComponentModel.DataAnnotations;

namespace Lxk.Ucenter.Core.Authorization.Roles
{
    public class Role : AbpRole<User>
    {
        public const int MaxDescriptionLength = 5000;

        public Role()
        {
        }

        public Role(int? tenantId, string displayName)
            : base(tenantId, displayName)
        {
        }

        public Role(int? tenantId, string name, string displayName)
            : base(tenantId, name, displayName)
        {
        }

        [StringLength(MaxDescriptionLength)]
        public string Description { get; set; }

    }
}
