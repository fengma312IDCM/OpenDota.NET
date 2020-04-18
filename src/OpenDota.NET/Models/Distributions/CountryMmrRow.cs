namespace OpenDotaDotNet.Models.Distributions
{
    using System.Text.Json.Serialization;

    public class CountryMmrRow
    {
        [JsonPropertyName("loccountrycode")]
        public string LocCountryCode { get; set; }

        [JsonPropertyName("count")]
        public long Count { get; set; }

        [JsonPropertyName("avg")]
        public long Avg { get; set; }

        [JsonPropertyName("common")]
        public string Common { get; set; }
    }
}
