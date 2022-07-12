using System.Collections.Generic;
using System.Text.Json.Serialization;
using TerritoryData.Lib.DB.Entity;

namespace TerritoryData.Lib.Web.Model
{
    public class Level3DivisionResponse
    {
        [JsonPropertyName("division")]
        public Level3Division Division { get; set; }
    }
}
