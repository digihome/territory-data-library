using Module.TerritoryData.Lib.Entity.GeoPortal;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using TerritoryData.Lib.Entity;
using TerritoryData.Lib.Interface;

namespace TerritoryData.Lib.Repository
{
    public class GeoPortalRepository : ITerritoryDataRepository
    {
        private readonly Energy.Base.Url baseUrl = new Energy.Base.Url($"http://mapy.geoportal.gov.pl/wss/service/SLN/guest/sln");
        private readonly string geoNamespace = "PL.PZGIK.200";
        public Address GetAddress(string addressCode)
        {
            throw new NotImplementedException();
        }

        public List<Address> GetAddressList(SearchParams searchParams)
        {
            throw new NotImplementedException();
        }

        public City GetCity(string cityCode)
        {
            throw new NotImplementedException();
        }

        public List<City> GetCityList(SearchParams searchParams)
        { 
            throw new NotImplementedException();
        }

        public Country GetCountry(string countryCode)
        {
            if (string.IsNullOrWhiteSpace(countryCode))
                return null;
            throw new NotImplementedException();
        }

        public List<Country> GetCountryList()
        {
            List<Country> countryList = new List<Country>();
            countryList.Add(new Country() { Id = "1", Code = "pl", Name = "Poland" });
            countryList.Add(new Country() { Id = "2", Code = "de", Name = "Germany" });
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
    }
}
