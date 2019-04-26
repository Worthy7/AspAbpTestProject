using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TestMPWAAspAbp.Authorization.Roles;
using TestMPWAAspAbp.Authorization.Users;
using TestMPWAAspAbp.MultiTenancy;
using TestMPWAAspAbp.Other;

namespace TestMPWAAspAbp.EntityFrameworkCore
{
    public class TestMPWAAspAbpDbContext : AbpZeroDbContext<Tenant, Role, User, TestMPWAAspAbpDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<SomeEntity> SomeEntitys { get; set; }

        public TestMPWAAspAbpDbContext(DbContextOptions<TestMPWAAspAbpDbContext> options)
            : base(options)
        {
        }
    }
}
