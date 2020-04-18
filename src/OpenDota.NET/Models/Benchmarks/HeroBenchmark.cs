namespace OpenDotaDotNet.Models.Benchmarks
{
    using System.Text.Json.Serialization;

    public class HeroBenchmark
    {
        /// <summary>
        /// Gets or sets the ID value of the hero played.
        /// </summary>
        [JsonPropertyName("hero_id")]
        public long HeroId { get; set; }

        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        [JsonPropertyName("result")]
        public HeroBenchmarkResult Result { get; set; }
    }
}
