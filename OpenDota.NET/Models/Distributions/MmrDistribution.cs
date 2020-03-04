namespace OpenDotaDotNet.Models.Distributions
{
    using System.Text.Json.Serialization;

    public class MmrDistribution
    {
        /// <summary>
        /// Gets or sets the ranks.
        /// </summary>
        [JsonPropertyName("ranks")]
        public Mmr Ranks { get; set; }

        /// <summary>
        /// Gets or sets the MMR.
        /// </summary>
        [JsonPropertyName("mmr")]
        public Mmr Mmr { get; set; }

        /// <summary>
        /// Gets or sets the country MMR.
        /// </summary>
        [JsonPropertyName("country_mmr")]
        public CountryMmr CountryMmr { get; set; }
    }
}
