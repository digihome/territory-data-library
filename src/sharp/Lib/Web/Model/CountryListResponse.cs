using System.Collections.Generic;
using System.Text.Json.Serialization;
using TerritoryData.Lib.Web.Entity;

namespace TerritoryData.Lib.Web.Model
{
    public class CountryListResponse
    {
        [JsonPropertyName("countries")]
        public List<Country> Countries { get; set; } = new List<Country>();
    }
}
