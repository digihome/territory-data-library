using System.Collections.Generic;
using TerritoryData.Library.Entity;

namespace TerritoryData.Library.Interface
{
    public interface ITerritoryDataRepository
    {
        Country GetCountry(string countryCode);
        List<Country> GetCountryList();
        Level1Division GetLevel1Division(string level1DivisionCode);
        List<Level1Division> GetLevel1DivisionList(SearchParams searchParams);
        Level2Division GetLevel2Division(string level2DivisionCode);
        List<Level2Division> GetLevel2DivisionList(SearchParams searchParams);
        Level3Division GetLevel3Division(string level3DivisionCode);
        List<Level3Division> GetLevel3DivisionList(SearchParams searchParams);
        City GetCity(string cityCode);
        List<City> GetCityList(SearchParams searchParams);
        Address GetAddress(string addressCode);
        List<Address> GetAddressList(SearchParams searchParams);

    }
}
