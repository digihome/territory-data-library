using TerritoryData.Lib.Web.Model;

namespace TerritoryData.Lib.Web.Interface
{
    public interface ITerritoryDataController
    {
        CountryListResponse GetCountryList();
    }
}
