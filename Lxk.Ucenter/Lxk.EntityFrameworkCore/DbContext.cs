using Abp.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Lxk.Ucenter.Core.Authorization.Roles;
using Lxk.Ucenter.Core.Authorization.Users;
using Lxk.Ucenter.Core.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace Lxk.Ucenter.EntityFrameworkCore
{
    public class DbContext : AbpZeroDbContext<Tenant, Role, User, DbContext>
    {
        public DbContext(DbContextOptions<DbContext> options)
            : base(options)
        {
        }

    }
}
