using System.Threading.Tasks;
using NUnit.Framework;
using ServiceStack.OrmLite;
using SimpleORMLite;

namespace Tests
{
    public class Tests
    {
        private OrmLiteConnectionFactory dbFactory;

        [SetUp]
        public void Setup()
        {
            dbFactory = new OrmLiteConnectionFactory(":memory:", SqliteDialect.Provider);
       
        }

        [Test]
        public async Task Should_return_result_with_corresponding_ID()
        {
            var repo = new DbFunctions(dbFactory);

            var result = await repo.GetById(1);

            Assert.That(result.Id, Is.EqualTo(1));

        }
    }
}