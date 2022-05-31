using Module.TerritoryData.Library.Interfaces;
using Module.TerritoryData.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.TerritoryData.Library
{
    internal class TerritoryDataRepository : ITerritoryDataRepository
    {
        public Address Address(string addressCode)
        {
            throw new NotImplementedException();
        }

        public AddressList GetAddressList(SearchParams searchParams)
        {
            throw new NotImplementedException();
        }

        public City GetCity(string cityCode)
        {
            throw new NotImplementedException();
        }

        public CityList GetCityList(SearchParams searchParams)
        {
            throw new NotImplementedException();
        }

        public Country GetCountry(string countryCode)
        {
            throw new NotImplementedException();
        }

        public CountryList GetCountryList()
        {
            CountryList countryList = new CountryList();
            countryList.Add(new Country() { Id = 1, Code = "pl", Name = "Poland" });
            countryList.Add(new Country() { Id = 1, Code = "de", Name = "Germany" });
            return countryList;
        }

        public Zone1 GetZone1(string zone1Code)
        {
            throw new NotImplementedException();
        }

        public Zone1List GetZone1List(SearchParams searchParams)
        {
            throw new NotImplementedException();
        }

        public Zone2 GetZone2(string zone2Code)
        {
            throw new NotImplementedException();
        }

        public Zone2List GetZone2List(SearchParams searchParams)
        {
            throw new NotImplementedException();
        }

        public Zone3 GetZone3(string zone3Code)
        {
            throw new NotImplementedException();
        }

        public Zone3List GetZone3List(SearchParams searchParams)
        {
            throw new NotImplementedException();
        }
    }
}
