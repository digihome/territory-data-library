using FakeItEasy;
using NUnit.Framework;
using Shouldly;
using TerritoryData.Lib;

namespace TerritoryData.Tests.Lib
{
    public class SqlStoreRepositoryTests
    {
        private SqlStoreRepository _repository;

        [SetUp]
        public void Setup()
        {
            _repository = A.Fake<SqlStoreRepository>();
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void GetCountry_Should_Return_Null_When_Parameter_Is_Empty(string countryCode)
        {
            var country = _repository.GetCountry(countryCode);
            country.ShouldBe(null);
        }
    }
}