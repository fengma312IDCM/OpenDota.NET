namespace OpenDotaDotNet.Models.Replays
{
    using System.Text.Json.Serialization;

    public class Replay
    {
        [JsonPropertyName("match_id")]
        public long MatchId { get; set; }

        [JsonPropertyName("cluster")]
        public long Cluster { get; set; }

        [JsonPropertyName("replay_salt")]
        public long ReplaySalt { get; set; }

        [JsonPropertyName("series_id")]
        public long? SeriesId { get; set; }

        [JsonPropertyName("series_type")]
        public long? SeriesType { get; set; }
    }
}
