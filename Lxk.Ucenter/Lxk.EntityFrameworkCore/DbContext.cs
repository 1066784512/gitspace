using Abp.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Lxk.Core.Authorization.Roles;
using Lxk.Core.Authorization.Users;
using Lxk.Core.MultiTenancy;
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
