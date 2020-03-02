namespace OpenDotaDotNet.Models.FindMatches
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class FindMatch
    {
        [JsonProperty("match_id")]
        public long MatchId { get; set; }

        [JsonProperty("teama")]
        public List<int> TeamA { get; set; }

        [JsonProperty("teamb")]
        public List<int> TeamB { get; set; }

        [JsonProperty("teamawin")]
        public bool TeamAWin { get; set; }

        [JsonProperty("start_time")]
        public long? StartTime { get; set; }
    }
}
