using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Lxk.Ucenter.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
