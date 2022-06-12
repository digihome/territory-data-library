using FakeItEasy;
using Module.TerritoryData.Lib.Repository;
using NUnit.Framework;
using Shouldly;

namespace TerritoryData.Tests.Lib.Repository
{
    public class SqlRepositoryTests
    {
        private SqlRepository _repository;

        [SetUp]
        public void Setup()
        {
            _repository = A.Fake<SqlRepository>();
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