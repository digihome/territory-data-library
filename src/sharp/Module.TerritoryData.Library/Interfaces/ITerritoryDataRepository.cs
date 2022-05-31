using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module.TerritoryData.Library.Models;

namespace Module.TerritoryData.Library.Interfaces
{
    public interface ITerritoryDataRepository
    {
        Country GetCountry(string countryCode);
        CountryList GetCountryList();
        Zone1 GetZone1(string zone1Code);
        Zone1List GetZone1List(SearchParams searchParams);
        Zone2 GetZone2(string zone2Code);
        Zone2List GetZone2List(SearchParams searchParams);
        Zone3 GetZone3(string zone3Code);
        Zone3List GetZone3List(SearchParams searchParams);
        City GetCity(string cityCode);
        CityList GetCityList(SearchParams searchParams);
        Address Address(string addressCode);
        AddressList GetAddressList(SearchParams searchParams);

    }
}
