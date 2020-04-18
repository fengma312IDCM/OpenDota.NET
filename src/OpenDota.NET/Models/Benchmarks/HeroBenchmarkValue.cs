namespace OpenDotaDotNet.Models.Benchmarks
{
    using System.Text.Json.Serialization;

    public class HeroBenchmarkValue
    {
        /// <summary>
        /// Gets or sets the percentile.
        /// </summary>
        [JsonPropertyName("percentile")]
        public double Percentile { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }
}
