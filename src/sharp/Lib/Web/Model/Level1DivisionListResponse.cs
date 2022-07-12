using System.Collections.Generic;
using System.Text.Json.Serialization;
using TerritoryData.Lib.DB.Entity;

namespace TerritoryData.Lib.Web.Model
{
    public class Level1DivisionListResponse
    {
        [JsonPropertyName("divisions")]
        public List<Level1Division> Divisions { get; set; } = new List<Level1Division>();
    }
}
