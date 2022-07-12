using System.Text.Json.Serialization;

namespace TerritoryData.Lib.Web.Entity
{
    public class Country
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("code")]
        public string Code { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }

    }
}
