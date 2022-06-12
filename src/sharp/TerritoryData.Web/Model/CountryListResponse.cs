using System.Collections.Generic;
using TerritoryData.Lib.Entity;

namespace Module.TerritoryData.Web.Model
{
    public class CountryListResponse
    {
        public List<Country> Countries { get; set; } = new List<Country>();
    }
}
