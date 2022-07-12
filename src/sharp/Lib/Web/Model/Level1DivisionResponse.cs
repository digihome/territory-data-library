using System.Collections.Generic;
using System.Text.Json.Serialization;
using TerritoryData.Lib.DB.Entity;

namespace TerritoryData.Lib.Web.Model
{
    public class Level1DivisionResponse
    {
        [JsonPropertyName("division")]
        public Level1Division Division { get; set; }
    }
}
