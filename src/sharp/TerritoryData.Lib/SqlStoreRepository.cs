using Microsoft.Data.SqlClient;
using TerritoryData.Lib.Interface;
using System;
using TerritoryData.Lib.Entity;
using System.Collections.Generic;

namespace TerritoryData.Lib
{
    public class SqlStoreRepository : ITerritoryDataRepository
    {
        private readonly System.Data.Common.DbConnection dbConnection;
        public SqlStoreRepository(SqlConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }
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
            throw new NotImplementedException();
        }

        public List<Level1Division> GetLevel1DivisionList(string countryCode)
        {
            throw new NotImplementedException();
        }

        public Level2Division GetLevel2Division(string level2DivisionCode)
        {
            throw new NotImplementedException();
        }

        public List<Level2Division> GetLevel2DivisionList(string level1DivisionCode)
        {
            throw new NotImplementedException();
        }

        public Level3Division GetLevel3Division(string level3DivisionCode)
        {
            throw new NotImplementedException();
        }

        public List<Level3Division> GetLevel3DivisionList(string level2DivisionCode)
        {
            throw new NotImplementedException();
        }
    }
}
