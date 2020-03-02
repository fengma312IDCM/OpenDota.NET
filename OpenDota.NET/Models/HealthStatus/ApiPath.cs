namespace OpenDotaDotNet.Models.HealthStatus
{
    using Newtonsoft.Json;

    public class ApiPath
    {
        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("count")]
        public string Count { get; set; }
    }
}
