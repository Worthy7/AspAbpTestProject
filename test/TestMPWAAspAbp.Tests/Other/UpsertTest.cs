using Abp.Domain.Repositories;
using TestMPWAAspAbp.Other;
using Xunit;

namespace TestMPWAAspAbp.Tests
{
    public class UpsertTest : TestMPWAAspAbpTestBase
    {
        private IRepository<SomeEntity, string> _someEntityRepo;

        public UpsertTest()
        {
            _someEntityRepo = Resolve<IRepository<SomeEntity, string>>();
        }

        [Fact]
        public void UpsertWithDatabaseGeneratedOptionNone()
        {
            // Act
             _someEntityRepo.InsertOrUpdate(
                new SomeEntity
                {
                    Id = "AnId"
                });
        }
    }
}
