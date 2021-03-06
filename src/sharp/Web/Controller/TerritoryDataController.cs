using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TerritoryData.Lib.Interface.DB.Repository;
using TerritoryData.Lib.Interface.Web.Controller;
using TerritoryData.Lib.Web.Entity;
using TerritoryData.Lib.Web.Model;

namespace TerritoryData.Web.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerritoryDataController : ControllerBase, ITerritoryDataController
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
                response.Countries = territoryDataRepository.GetCountryList()
                    .Select(c => new Country()
                    {
                        Id = c.Id,
                        Code = c.Code,
                        Name = c.Name
                    }).ToList();
            }
            finally
            {

            }
            return response;
        }

        [HttpGet("country/{countryCode}")]
        public CountryResponse GetCountry([FromQuery] string countryCode)
        {
            CountryResponse response = new CountryResponse();
            try
            {
                response.Country = territoryDataRepository.GetCountry(countryCode);
            }
            finally
            {

            }
            return response;
        }

        [HttpGet("level1-division")]
        public Level1DivisionListResponse GetLevel1DivisionList(string countryCode)
        {
            Level1DivisionListResponse response = new Level1DivisionListResponse();
            try
            {
                response.Divisions = territoryDataRepository.GetLevel1DivisionList(countryCode);
            }
            finally
            {

            }
            return response;
        }

        [HttpGet("level1-division/{level1DivisionCode}")]
        public Level1DivisionResponse GetLevel1Division([FromQuery] string level1DivisionCode)
        {
            Level1DivisionResponse response = new Level1DivisionResponse();
            try
            {
                response.Division = territoryDataRepository.GetLevel1Division(level1DivisionCode);
            }
            finally
            {

            }
            return response;
        }

        [HttpGet("level2-division")]
        public Level2DivisionListResponse GetLevel2DivisionList(string level1DivisionCode)
        {
            Level2DivisionListResponse response = new Level2DivisionListResponse();
            try
            {
                response.Divisions = territoryDataRepository.GetLevel2DivisionList(level1DivisionCode);
            }
            finally
            {

            }
            return response;
        }

        [HttpGet("level2-division/{level2DivisionCode}")]
        public Level2DivisionResponse GetLevel2Division([FromQuery] string level2DivisionCode)
        {
            Level2DivisionResponse response = new Level2DivisionResponse();
            try
            {
                response.Division = territoryDataRepository.GetLevel2Division(level2DivisionCode);
            }
            finally
            {

            }
            return response;
        }

        [HttpGet("level3-division")]
        public Level3DivisionListResponse GetLevel3DivisionList(string level2DivisionCode)
        {
            Level3DivisionListResponse response = new Level3DivisionListResponse();
            try
            {
                response.Divisions = territoryDataRepository.GetLevel3DivisionList(level2DivisionCode);
            }
            finally
            {

            }
            return response;
        }

        [HttpGet("level3-division/{level3DivisionCode}")]
        public Level3DivisionResponse GetLevel3Division([FromQuery] string level3DivisionCode)
        {
            Level3DivisionResponse response = new Level3DivisionResponse();
            try
            {
                response.Division = territoryDataRepository.GetLevel3Division(level3DivisionCode);
            }
            finally
            {

            }
            return response;
        }
    }
}
