using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TestMPWAAspAbp.Configuration;
using TestMPWAAspAbp.Web;

namespace TestMPWAAspAbp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TestMPWAAspAbpDbContextFactory : IDesignTimeDbContextFactory<TestMPWAAspAbpDbContext>
    {
        public TestMPWAAspAbpDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TestMPWAAspAbpDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TestMPWAAspAbpDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TestMPWAAspAbpConsts.ConnectionStringName));

            return new TestMPWAAspAbpDbContext(builder.Options);
        }
    }
}
