using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TestMPWAAspAbp.EntityFrameworkCore
{
    public static class TestMPWAAspAbpDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TestMPWAAspAbpDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TestMPWAAspAbpDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
