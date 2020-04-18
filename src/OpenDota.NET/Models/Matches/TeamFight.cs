namespace OpenDotaDotNet.Models.Matches
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class Teamfight
    {
        // The time (in seconds) when the teamfight started
        [JsonPropertyName("start")]
        public int Start { get; set; }

        // The time (in seconds) when the teamfight ended
        [JsonPropertyName("end")]
        public int End { get; set; }

        // The time (in seconds) when the last death occured in the teamfight
        [JsonPropertyName("last_death")]
        public long LastDeath { get; set; }

        // The amount of total deaths during the teamfight
        [JsonPropertyName("deaths")]
        public long Deaths { get; set; }

        // Players involved in the teamfight
        [JsonPropertyName("players")]
        public IEnumerable<TeamfightPlayer> Players { get; set; }
    }
}
