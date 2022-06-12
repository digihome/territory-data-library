using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Module.TerritoryData.Web.Model;
using TerritoryData.Lib.Interface;

namespace Module.TerritoryData.Web.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerritoryDataController : ControllerBase
    {
        private readonly ITerritoryDataRepository territoryDataRepository;
        public TerritoryDataController(ITerritoryDataRepository territoryDataRepository)
        {
            this.territoryDataRepository = territoryDataRepository;
        }

        [HttpGet("country")]
        public CountryListResponse GetCountryList()
        {
            CountryListResponse response = new CountryListResponse();
            try
            {
                response.Countries = territoryDataRepository.GetCountryList();
            }
            finally
            {

            }
            return response;
        }

        [HttpGet("country")]
        public CountryListResponse GetCountry([FromQuery] string countryCode)
        {
            CountryListResponse response = new CountryListResponse();
            try
            {
                response.Countries = territoryDataRepository.GetCountryList();
            }
            finally
            {

            }
            return response;
        }

    }
}
