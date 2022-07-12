using System.Collections.Generic;
using System.Text.Json.Serialization;
using TerritoryData.Lib.DB.Entity;

namespace TerritoryData.Lib.Web.Model
{
    public class Level2DivisionResponse
    {
        [JsonPropertyName("division")]
        public Level2Division Division { get; set; }
    }
}
