namespace OpenDotaDotNet.Models.HealthStatus
{
    using Newtonsoft.Json;

    public class Last
    {
        [JsonProperty("match_id")]
        public long MatchId { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("start_time")]
        public long StartTime { get; set; }
    }
}
