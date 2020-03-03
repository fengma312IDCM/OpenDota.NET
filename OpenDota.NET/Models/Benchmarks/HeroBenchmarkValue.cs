namespace OpenDotaDotNet.Models.Benchmarks
{
    using System.Text.Json.Serialization;

    public class HeroBenchmarkValue
    {
        [JsonPropertyName("percentile")]
        public double Percentile { get; set; }

        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }
}
