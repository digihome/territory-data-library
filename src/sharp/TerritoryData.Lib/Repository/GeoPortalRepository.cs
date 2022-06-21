using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using TerritoryData.Lib.Entity;
using TerritoryData.Lib.Entity.GeoPortal;
using TerritoryData.Lib.Interface;

namespace TerritoryData.Lib.Repository
{
    public class GeoPortalRepository : ITerritoryDataRepository
    {
        private readonly Energy.Base.Url baseUrl = new Energy.Base.Url($"http://mapy.geoportal.gov.pl/wss/service/SLN/guest/sln");
        private readonly string geoNamespace = "PL.PZGIK.200";

        // ulice
        // http://mapy.geoportal.gov.pl/wss/service/SLN/guest/sln/adr/ul/PL.PZGIK.200/5ecae524-66c9-465d-8677-29e5ab0744a8/skr.json

        public Address GetAddress(string addressCode)
        {
            throw new NotImplementedException();
        }

        public List<Address> GetAddressList(SearchParams searchParams)
        {
            // http://mapy.geoportal.gov.pl/wss/service/SLN/guest/sln/adr/miejsc/PL.PZGIK.200/4c52f220-87d7-41e3-ae03-6a25f1b20e00/skr.json
            throw new NotImplementedException();
        }

        public City GetCity(string level3DivisionCode, string cityCode)
        {
            if (string.IsNullOrWhiteSpace(cityCode))
                return null;
            //TODO: what is cityCode length
            if (cityCode.Length != 7)
                throw new Exception("Invalid cityCode length.");
            var cityList = GetCityList(level3DivisionCode);
            if (cityList == null)
                return null;
            return cityList.Where(d => d.Code == cityCode).FirstOrDefault();
        }

        public List<City> GetCityList(string level3DivisionCode)
        {
            if (string.IsNullOrWhiteSpace(level3DivisionCode))
                return null;
            if (level3DivisionCode.Length != 9)
                throw new Exception("Invalid level3DivisionCode length.");
            string countryCode = level3DivisionCode.Substring(0, 2);
            // For foreign countries return empty list
            if (countryCode.ToUpper() != "PL")
                return new List<City>();
            var level3Division = GetLevel3Division(level3DivisionCode);
            if (level3Division == null)
                return null;
            string queryUrl = Energy.Base.Url.Make(baseUrl.ToString(), null, null, null, Energy.Base.Url.Combine(baseUrl.Path, "miejsc", geoNamespace, level3Division.Id, "skr.json"), null, null);
            var response = Energy.Core.Web.Get(queryUrl);
            if (response == null)
                return null;
            if (response.StatusCode != (int)HttpStatusCode.OK)
                return null;
            JObject responseJson = JsonConvert.DeserializeObject<JObject>(response.Body);
            var cityList = responseJson.SelectToken("miejscowosci").Children().Select(t => t.SelectToken("miejscowosc").ToObject<Miejscowosc>()).ToList();
            return cityList.Select(t => new City() { Id = t.miejscIIPId, Code = t.miejscIdTeryt, Name = t.miejscNazwa }).ToList();
        }

        public Country GetCountry(string countryCode)
        {
            if (string.IsNullOrWhiteSpace(countryCode))
                return null;
            if (countryCode.Length != 2)
                throw new Exception("Invalid countryCode length.");
            var countryList = GetCountryList();
            if (countryList == null)
                return null;
            return countryList.Where(d => d.Code == countryCode.ToUpper()).FirstOrDefault();
        }

        public List<Country> GetCountryList()
        {
            List<Country> countryList = new List<Country>();
            countryList.Add(new Country() { Id = "1", Code = "PL", Name = "Poland" });
            countryList.Add(new Country() { Id = "2", Code = "DE", Name = "Germany" });
            return countryList;
        }

        public Level1Division GetLevel1Division(string level1DivisionCode)
        {
            if (string.IsNullOrWhiteSpace(level1DivisionCode))
                return null;
            if (level1DivisionCode.Length != 4)
                throw new Exception("Invalid level1DivisionCode length.");
            string countryCode = level1DivisionCode.Substring(0, 2);
            var level1DivisionList = GetLevel1DivisionList(countryCode);
            if (level1DivisionList == null)
                return null;
            return level1DivisionList.Where(d => d.Code == level1DivisionCode).FirstOrDefault();
        }

        public List<Level1Division> GetLevel1DivisionList(string countryCode)
        {
            if (string.IsNullOrWhiteSpace(countryCode))
                return null;
            if (countryCode.Length != 2)
                throw new Exception("Invalid countryCode length.");
            // For foreign countries return empty list
            if (countryCode.ToUpper() != "PL")
                return new List<Level1Division>();
            string queryUrl = Energy.Base.Url.Make(baseUrl.ToString(), null, null, null, Energy.Base.Url.Combine(baseUrl.Path, "woj.json"), null, null);
            var response = Energy.Core.Web.Get(queryUrl);
            if (response == null)
                return null;
            if (response.StatusCode != (int)HttpStatusCode.OK)
                return null;
            JObject responseJson = JsonConvert.DeserializeObject<JObject>(response.Body);
            var jednAdmList = responseJson.SelectToken("jednAdms").Children().Select(t => t.SelectToken("jednAdm").ToObject<JednAdm>()).ToList();
            return jednAdmList.Select(t => new Level1Division() { Id = t.wojIIPId, Code = countryCode + t.wojIdTeryt, Name = t.wojNazwa }).ToList();
        }

        public Level2Division GetLevel2Division(string level2DivisionCode)
        {
            if (string.IsNullOrWhiteSpace(level2DivisionCode))
                return null;
            if (level2DivisionCode.Length != 6)
                throw new Exception("Invalid level2DivisionCode length.");
            string level1DivisionCode = level2DivisionCode.Substring(0, 4);
            var level2DivisionList = GetLevel2DivisionList(level1DivisionCode);
            if (level2DivisionList == null)
                return null;
            return level2DivisionList.Where(d => d.Code == level2DivisionCode).FirstOrDefault();
        }

        public List<Level2Division> GetLevel2DivisionList(string level1DivisionCode)
        {
            if (string.IsNullOrWhiteSpace(level1DivisionCode))
                return null;
            if (level1DivisionCode.Length != 4)
                throw new Exception("Invalid level1DivisionCode length.");
            string countryCode = level1DivisionCode.Substring(0, 2);
            // For foreign countries return empty list
            if (countryCode.ToUpper() != "PL")
                return new List<Level2Division>();
            var level1Division = GetLevel1Division(level1DivisionCode);
            if (level1Division == null)
                return null;
            string queryUrl = Energy.Base.Url.Make(baseUrl.ToString(), null, null, null, Energy.Base.Url.Combine(baseUrl.Path, "pow", geoNamespace, level1Division.Id , "skr.json"), null, null);
            var response = Energy.Core.Web.Get(queryUrl);
            if (response == null)
                return null;
            if (response.StatusCode != (int)HttpStatusCode.OK)
                return null;
            JObject responseJson = JsonConvert.DeserializeObject<JObject>(response.Body);
            var jednAdmList = responseJson.SelectToken("jednAdms").Children().Select(t => t.SelectToken("jednAdm").ToObject<JednAdm>()).ToList();
            return jednAdmList.Select(t => new Level2Division() { Id = t.powIIPId, Code = countryCode + t.powIdTeryt, Name = t.powNazwa }).ToList();
        }

        public Level3Division GetLevel3Division(string level3DivisionCode)
        {
            if (string.IsNullOrWhiteSpace(level3DivisionCode))
                return null;
            if (level3DivisionCode.Length != 9)
                throw new Exception("Invalid level3DivisionCode length.");
            string level2DivisionCode = level3DivisionCode.Substring(0, 6);
            var level3DivisionList = GetLevel3DivisionList(level2DivisionCode);
            if (level3DivisionList == null)
                return null;
            return level3DivisionList.Where(d => d.Code == level3DivisionCode).FirstOrDefault();
        }

        public List<Level3Division> GetLevel3DivisionList(string level2DivisionCode)
        {
            if (string.IsNullOrWhiteSpace(level2DivisionCode))
                return null;
            if (level2DivisionCode.Length != 6)
                throw new Exception("Invalid level2DivisionCode length.");
            string countryCode = level2DivisionCode.Substring(0, 2);
            // For foreign countries return empty list
            if (countryCode.ToUpper() != "PL")
                return new List<Level3Division>();
            var level2Division = GetLevel2Division(level2DivisionCode);
            if (level2Division == null)
                return null;
            string queryUrl = Energy.Base.Url.Make(baseUrl.ToString(), null, null, null, Energy.Base.Url.Combine(baseUrl.Path, "gmi", geoNamespace, level2Division.Id, "skr.json"), null, null);
            var response = Energy.Core.Web.Get(queryUrl);
            if (response == null)
                return null;
            if (response.StatusCode != (int)HttpStatusCode.OK)
                return null;
            JObject responseJson = JsonConvert.DeserializeObject<JObject>(response.Body);
            var jednAdmList = responseJson.SelectToken("jednAdms").Children().Select(t => t.SelectToken("jednAdm").ToObject<JednAdm>()).ToList();
            return jednAdmList.Select(t => new Level3Division() { Id = t.gmIIPId, Code = countryCode + t.gmIdTeryt, Name = t.gmNazwa }).ToList();
        }

        public Street GetStreet(string streetCode)
        {
            throw new NotImplementedException();
        }

        public List<Street> GetStreetList(SearchParams searchParams)
        {
            throw new NotImplementedException();
        }
    }
}
