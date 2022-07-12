using System.Collections.Generic;
using System.Text.Json.Serialization;
using TerritoryData.Lib.DB.Entity;

namespace TerritoryData.Lib.Web.Model
{
    public class Level3DivisionListResponse
    {
        [JsonPropertyName("divisions")]
        public List<Level3Division> Divisions { get; set; } = new List<Level3Division>();
    }
}
