using TerritoryData.Lib.Web.Model;

namespace TerritoryData.Lib.Interface.Web.Controller
{
    public interface ITerritoryDataController
    {
        CountryListResponse GetCountryList();
    }
}
