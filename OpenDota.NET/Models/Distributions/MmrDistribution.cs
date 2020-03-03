namespace OpenDotaDotNet.Models.Distributions
{
    using System.Text.Json.Serialization;

    public class MmrDistribution
    {
        [JsonPropertyName("ranks")]
        public Mmr Ranks { get; set; }

        [JsonPropertyName("mmr")]
        public Mmr Mmr { get; set; }

        [JsonPropertyName("country_mmr")]
        public CountryMmr CountryMmr { get; set; }
    }
}
