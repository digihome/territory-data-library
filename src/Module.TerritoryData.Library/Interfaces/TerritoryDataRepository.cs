using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.TerritoryData.Library.Interfaces
{
    public interface TerritoryDataRepository
    {
        Models.Country GetCountry(string countryCode);
        Models.CountryList GetCountryList();
        Models.Zone1 GetZone1(string zone1Code);
        Models.Zone1List GetZone1List(Models.SearchParams searchParams);
        Models.Zone2 GetZone2(string zone2Code);
        Models.Zone2List GetZone2List(Models.SearchParams searchParams);
        Models.Zone3 GetZone3(string zone3Code);
        Models.Zone3List GetZone3List(Models.SearchParams searchParams);
        Models.City GetCity(string cityCode);
        Models.CityList GetCityList(Models.SearchParams searchParams);
        Models.Address Address(string addressCode);
        Models.AddressList GetAddressList(Models.SearchParams searchParams);

    }
}
