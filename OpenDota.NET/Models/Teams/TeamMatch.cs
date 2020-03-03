namespace OpenDotaDotNet.Models.Teams
{
    using System;
    using System.Text.Json.Serialization;

    public class TeamMatch
    {
        [JsonPropertyName("match_id")]
        public long MatchId { get; set; }

        [JsonPropertyName("radiant_win")]
        public bool RadiantWin { get; set; }

        [JsonPropertyName("radiant")]
        public bool Radiant { get; set; }

        [JsonPropertyName("duration")]
        public long Duration { get; set; }

        [JsonPropertyName("start_time")]
        public long StartTime { get; set; }

        [JsonPropertyName("leagueid")]
        public long Leagueid { get; set; }

        [JsonPropertyName("league_name")]
        public string LeagueName { get; set; }

        [JsonPropertyName("cluster")]
        public long Cluster { get; set; }

        [JsonPropertyName("opposing_team_id")]
        public long OpposingTeamId { get; set; }

        [JsonPropertyName("opposing_team_name")]
        public string OpposingTeamName { get; set; }

        [JsonPropertyName("opposing_team_logo")]
        public Uri OpposingTeamLogo { get; set; }
    }
}
