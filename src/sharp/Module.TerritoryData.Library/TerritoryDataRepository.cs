using Module.TerritoryData.Library.Interfaces;
using Module.TerritoryData.Library.Models;
using Module.TerritoryData.Library.Models.Hierarchy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.TerritoryData.Library
{
    internal class TerritoryDataRepository : ITerritoryDataRepository
    {
        public Address GetAddress(string addressCode)
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

        public Level1Division GetLevel1Division(string zone1Code)
        {
            throw new NotImplementedException();
        }

        public Level1DivisionList GetLevel1DivisionList(SearchParams searchParams)
        {
            throw new NotImplementedException();
        }

        public Level2Division GetLevel2Division(string zone2Code)
        {
            throw new NotImplementedException();
        }

        public Level2DivisionList GetLevel2DivisionList(SearchParams searchParams)
        {
            throw new NotImplementedException();
        }

        public Level3Division GetLevel3Division(string zone3Code)
        {
            throw new NotImplementedException();
        }

        public Level3DivisionList GetLevel3DivisionList(SearchParams searchParams)
        {
            throw new NotImplementedException();
        }
    }
}
