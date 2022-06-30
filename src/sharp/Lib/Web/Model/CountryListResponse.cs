using System.Collections.Generic;
using TerritoryData.Lib.Web.Entity;

namespace TerritoryData.Lib.Web.Model
{
    public class CountryListResponse
    {
        public List<Country> Countries { get; set; } = new List<Country>();
    }
}
