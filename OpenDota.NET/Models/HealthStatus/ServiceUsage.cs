namespace OpenDotaDotNet.Models.HealthStatus
{
    using System.Text.Json.Serialization;

    public class ServiceUsage
    {
        [JsonPropertyName("metric")]
        public double Metric { get; set; }

        [JsonPropertyName("threshold")]
        public long Threshold { get; set; }

        [JsonPropertyName("timestamp")]
        public long Timestamp { get; set; }
    }
}
