namespace OpenDotaDotNet.Models.Distributions
{
    using Newtonsoft.Json;

    public class CountryMmrRow
    {
        [JsonProperty("loccountrycode")]
        public string LocCountryCode { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("avg")]
        public long Avg { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }
}
