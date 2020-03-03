namespace OpenDotaDotNet.Models.Benchmarks
{
    using System.Text.Json.Serialization;

    public class HeroBenchmark
    {
        [JsonPropertyName("hero_id")]
        public long HeroId { get; set; }

        [JsonPropertyName("result")]
        public HeroBenchmarkResult Result { get; set; }
    }
}
