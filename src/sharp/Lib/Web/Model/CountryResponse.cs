using System.Collections.Generic;
using System.Text.Json.Serialization;
using TerritoryData.Lib.DB.Entity;

namespace TerritoryData.Lib.Web.Model
{
    public class CountryResponse
    {
        [JsonPropertyName("country")]
        public Country Country { get; set; }
    }
}
