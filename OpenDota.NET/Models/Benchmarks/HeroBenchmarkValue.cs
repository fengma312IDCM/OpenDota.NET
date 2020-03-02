namespace OpenDotaDotNet.Models.Benchmarks
{
    using Newtonsoft.Json;

    public class HeroBenchmarkValue
    {
        [JsonProperty("percentile")]
        public double Percentile { get; set; }

        [JsonProperty("value")]
        public double? Value { get; set; }
    }
}
