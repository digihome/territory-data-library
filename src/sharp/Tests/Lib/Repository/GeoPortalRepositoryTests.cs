using FakeItEasy;
using NUnit.Framework;
using Shouldly;
using TerritoryData.Lib.DB.Repository;

namespace TerritoryData.Tests.Lib.Repository
{
    public class GeoPortalRepositoryTests
    {
        private GeoPortalRepository _repository;

        [SetUp]
        public void Setup()
        {
            _repository = A.Fake<GeoPortalRepository>();
        }

        private readonly static object[] CountryListSource = new object[]
        {
            new TestCaseParams() { Arg = null, ExpectedResult = 2 },
        };

        [Test]
        [TestCaseSource(nameof(CountryListSource))]
        public void GetCountryList_Should_Return_Correct_Elements_Counts(object testCase)
        {
            int expectedResult = (int)((TestCaseParams)testCase).ExpectedResult;
            var countryList = _repository.GetCountryList();
            countryList.Count.ShouldBe(expectedResult);
        }

        private readonly static object[] CountrySource = new object[]
        {
            new TestCaseParams() { Arg = "pl", ExpectedResult = "Poland" },
            new TestCaseParams() { Arg = "PL", ExpectedResult = "Poland" },
        };

        [Test]
        [TestCaseSource(nameof(CountrySource))]
        public void GetCountry_Should_Return_Correct_Value(object testCase)
        {
            string countryCode = (string)((TestCaseParams)testCase).Arg;
            string expectedResult = (string)((TestCaseParams)testCase).ExpectedResult;
            var country = _repository.GetCountry(countryCode);
            country.Name.ShouldBe(expectedResult);
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

        private readonly static object[] Level1DivisionListSource = new object[]
        {
            new TestCaseParams() { Arg = "PL", ExpectedResult = 16 },
            new TestCaseParams() { Arg = "pl", ExpectedResult = 16 },
            new TestCaseParams() { Arg = "de", ExpectedResult = 0 }
        };

        [Test]
        [TestCaseSource(nameof(Level1DivisionListSource))]
        public void GetLevel1DivisionList_Should_Return_Correct_Elements_Counts(object testCase)
        {
            string countryCode = (string)((TestCaseParams)testCase).Arg;
            int expectedResult = (int)((TestCaseParams)testCase).ExpectedResult;
            var divisionList = _repository.GetLevel1DivisionList(countryCode);
            divisionList.Count.ShouldBe(expectedResult);
        }

        private readonly static object[] Level1DivisionSource = new object[]
        {
            new TestCaseParams() { Arg = "PL02", ExpectedResult = "dolnośląskie" },
            new TestCaseParams() { Arg = "pl02", ExpectedResult = "dolnośląskie" },
        };

        [Test]
        [TestCaseSource(nameof(Level1DivisionSource))]
        public void GetLevel1Division_Should_Return_Correct_Value(object testCase)
        {
            string level1DivisionCode = (string)((TestCaseParams)testCase).Arg;
            string expectedResult = (string)((TestCaseParams)testCase).ExpectedResult;
            var division = _repository.GetLevel1Division(level1DivisionCode);
            division.Name.ShouldBe(expectedResult);
        }

        private readonly static object[] Level2DivisionListSource = new object[]
        {
            new TestCaseParams() { Arg = "PL02", ExpectedResult = 30 },
            new TestCaseParams() { Arg = "pl02", ExpectedResult = 30 },
            new TestCaseParams() { Arg = "de00", ExpectedResult = 0 }
        };

        [Test]
        [TestCaseSource(nameof(Level2DivisionListSource))]
        public void GetLevel2DivisionList_Should_Return_Correct_Elements_Counts(object testCase)
        {
            string level1DivisionCode = (string)((TestCaseParams)testCase).Arg;
            int expectedResult = (int)((TestCaseParams)testCase).ExpectedResult;
            var divisionList = _repository.GetLevel2DivisionList(level1DivisionCode);
            divisionList.Count.ShouldBe(expectedResult);
        }

        private readonly static object[] Level2DivisionSource = new object[]
        {
            new TestCaseParams() { Arg = "PL0201", ExpectedResult = "bolesławiecki" },
            new TestCaseParams() { Arg = "pl0201", ExpectedResult = "bolesławiecki" },
        };


        [Test]
        [TestCaseSource(nameof(Level2DivisionSource))]
        public void GetLevel2Division_Should_Return_Correct_Value(object testCase)
        {
            string level2DivisionCode = (string)((TestCaseParams)testCase).Arg;
            string expectedResult = (string)((TestCaseParams)testCase).ExpectedResult;
            var division = _repository.GetLevel2Division(level2DivisionCode);
            division.Name.ShouldBe(expectedResult);
        }

        private readonly static object[] Level3DivisionListSource = new object[]
        {
            new TestCaseParams() { Arg = "PL0201", ExpectedResult = 6 },
            new TestCaseParams() { Arg = "pl0201", ExpectedResult = 6 },
            new TestCaseParams() { Arg = "de0000", ExpectedResult = 0 }
        };

        [Test]
        [TestCaseSource(nameof(Level3DivisionListSource))]
        public void GetLevel3DivisionList_Should_Return_Correct_Elements_Counts(object testCase)
        {
            string level2DivisionCode = (string)((TestCaseParams)testCase).Arg;
            int expectedResult = (int)((TestCaseParams)testCase).ExpectedResult;
            var divisionList = _repository.GetLevel3DivisionList(level2DivisionCode);
            divisionList.Count.ShouldBe(expectedResult);
        }


        private readonly static object[] Level3DivisionSource = new object[]
        {
            new TestCaseParams() { Arg = "PL0201011", ExpectedResult = "Bolesławiec" },
            new TestCaseParams() { Arg = "pl0201011", ExpectedResult = "Bolesławiec" },
        };


        [Test]
        [TestCaseSource(nameof(Level3DivisionSource))]
        public void GetLevel3Division_Should_Return_Correct_Value(object testCase)
        {
            string level3DivisionCode = (string)((TestCaseParams)testCase).Arg;
            string expectedResult = (string)((TestCaseParams)testCase).ExpectedResult;
            var division = _repository.GetLevel3Division(level3DivisionCode);
            division.Name.ShouldBe(expectedResult);
        }

        private readonly static object[] CityListSource = new object[]
        {
            new TestCaseParams() { Arg = "PL0201011", ExpectedResult = 2 },
            new TestCaseParams() { Arg = "pl0201011", ExpectedResult = 2 },
            new TestCaseParams() { Arg = "de0000000", ExpectedResult = 0 }
        };

        [Test]
        [TestCaseSource(nameof(CityListSource))]
        public void GetCityList_Should_Return_Correct_Elements_Counts(object testCase)
        {
            string level3DivisionCode = (string)((TestCaseParams)testCase).Arg;
            int expectedResult = (int)((TestCaseParams)testCase).ExpectedResult;
            var cityList = _repository.GetCityList(level3DivisionCode);
            cityList.Count.ShouldBe(expectedResult);
        }

        private readonly static object[] CitySource = new object[]
        {
            new TestCaseParams() { Arg = new string[] { "PL0201011", "sdfd" }, ExpectedResult = "Suwałki" },
            new TestCaseParams() { Arg = new string[] { "PL0201011", "sdfd" }, ExpectedResult = "Suwałki" },
        };

        [Test]
        [TestCaseSource(nameof(CitySource))]
        public void GetCity_Should_Return_Correct_Elements_Counts(object testCase)
        {
            string[] arg = (string[])((TestCaseParams)testCase).Arg;
            string level3DivisionCode = arg[0];
            string cityCode = arg[1];
            string expectedResult = (string)((TestCaseParams)testCase).ExpectedResult;
            var cityList = _repository.GetCity(level3DivisionCode, cityCode);
            cityList.Name.ShouldBe(expectedResult);
        }

    }
}