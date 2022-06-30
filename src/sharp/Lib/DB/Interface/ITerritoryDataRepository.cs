using System.Collections.Generic;
using TerritoryData.Lib.DB.Entity;

namespace TerritoryData.Lib.DB.Interface
{
    public interface ITerritoryDataRepository
    {
        Country GetCountry(string countryCode);
        List<Country> GetCountryList();
        Level1Division GetLevel1Division(string level1DivisionCode);
        List<Level1Division> GetLevel1DivisionList(string countryCode);
        Level2Division GetLevel2Division(string level2DivisionCode);
        List<Level2Division> GetLevel2DivisionList(string level1DivisionCode);
        Level3Division GetLevel3Division(string level3DivisionCode);
        List<Level3Division> GetLevel3DivisionList(string level2DivisionCode);
        City GetCity(string level3DivisionCode, string cityCode);
        List<City> GetCityList(string level3DivisionCode);
        Street GetStreet(string streetCode);
        List<Street> GetStreetList(SearchParams searchParams);

        Address GetAddress(string addressCode);
        List<Address> GetAddressList(SearchParams searchParams);

    }
}
