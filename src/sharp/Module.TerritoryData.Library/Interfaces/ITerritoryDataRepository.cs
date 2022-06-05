using Module.TerritoryData.Library.Models;
using Module.TerritoryData.Library.Models.Hierarchy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.TerritoryData.Library.Interfaces
{
    public interface ITerritoryDataRepository
    {
        Country GetCountry(string countryCode);
        CountryList GetCountryList();
        Level1Division GetLevel1Division(string zone1Code);
        Level1DivisionList GetLevel1DivisionList(SearchParams searchParams);
        Level2Division GetLevel2Division(string zone2Code);
        Level2DivisionList GetLevel2DivisionList(SearchParams searchParams);
        Level3Division GetLevel3Division(string zone3Code);
        Level3DivisionList GetLevel3DivisionList(SearchParams searchParams);
        City GetCity(string cityCode);
        CityList GetCityList(SearchParams searchParams);
        Address GetAddress(string addressCode);
        AddressList GetAddressList(SearchParams searchParams);

    }
}
