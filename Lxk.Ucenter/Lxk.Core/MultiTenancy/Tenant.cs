using Abp.MultiTenancy;
using Lxk.Ucenter.Core.Authorization.Users;

namespace Lxk.Ucenter.Core.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
        }

        public Tenant(string tenancyName, string name)
            :base(tenancyName, name)
        {
        }

    }
}
