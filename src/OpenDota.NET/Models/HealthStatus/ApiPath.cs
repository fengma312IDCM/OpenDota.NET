namespace OpenDotaDotNet.Models.HealthStatus
{
    using System.Text.Json.Serialization;

    public class ApiPath
    {
        [JsonPropertyName("hostname")]
        public string Hostname { get; set; }

        [JsonPropertyName("count")]
        public string Count { get; set; }
    }
}
