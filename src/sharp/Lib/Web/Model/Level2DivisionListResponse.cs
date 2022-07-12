using System.Collections.Generic;
using System.Text.Json.Serialization;
using TerritoryData.Lib.DB.Entity;

namespace TerritoryData.Lib.Web.Model
{
    public class Level2DivisionListResponse
    {
        [JsonPropertyName("divisions")]
        public List<Level2Division> Divisions { get; set; } = new List<Level2Division>();
    }
}
