namespace OpenDotaDotNet.Models.Benchmarks
{
    using Newtonsoft.Json;

    public class HeroBenchmark
    {
        [JsonProperty("hero_id")]
        public long HeroId { get; set; }

        [JsonProperty("result")]
        public HeroBenchmarkResult Result { get; set; }
    }
}
