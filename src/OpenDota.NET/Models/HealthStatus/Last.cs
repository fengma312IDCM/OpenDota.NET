namespace OpenDotaDotNet.Models.HealthStatus
{
    using System.Text.Json.Serialization;

    public class Last
    {
        [JsonPropertyName("match_id")]
        public long MatchId { get; set; }

        [JsonPropertyName("duration")]
        public int Duration { get; set; }

        [JsonPropertyName("start_time")]
        public long StartTime { get; set; }
    }
}
