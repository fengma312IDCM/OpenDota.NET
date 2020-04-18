namespace OpenDotaDotNet.Models.ProMatches
{
    using System.Text.Json.Serialization;

    public class ProMatch
    {
        /// <summary>
        /// Gets or sets ID used to identify individual matches, e.g. 3703866531.
        /// </summary>
        [JsonPropertyName("match_id")]
        public long MatchId { get; set; }

        /// <summary>
        /// Gets or sets length of the match.
        /// </summary>
        [JsonPropertyName("duration")]
        public int Duration { get; set; }

        /// <summary>
        /// Gets or sets Unix timestamp of when the match began.
        /// </summary>
        [JsonPropertyName("start_time")]
        public long StartTime { get; set; }

        /// <summary>
        /// Gets or sets the Radiant's team_id.
        /// </summary>
        [JsonPropertyName("radiant_team_id")]
        public long? RadiantTeamId { get; set; }

        /// <summary>
        /// Gets or sets the Radiant's team name.
        /// </summary>
        [JsonPropertyName("radiant_name")]
        public string RadiantName { get; set; }

        /// <summary>
        /// Gets or sets the Dire's team_id.
        /// </summary>
        [JsonPropertyName("dire_team_id")]
        public long? DireTeamId { get; set; }

        /// <summary>
        /// Gets or sets the Dire's team name.
        /// </summary>
        [JsonPropertyName("dire_name")]
        public string DireName { get; set; }

        /// <summary>
        /// Gets or sets identifier for the league the match took place in.
        /// </summary>
        [JsonPropertyName("leagueid")]
        public long LeagueId { get; set; }

        /// <summary>
        /// Gets or sets name of league the match took place in.
        /// </summary>
        [JsonPropertyName("league_name")]
        public string LeagueName { get; set; }

        /// <summary>
        /// Gets or sets identifier for the series of the match.
        /// </summary>
        [JsonPropertyName("series_id")]
        public long? SeriesId { get; set; }

        /// <summary>
        /// Gets or sets type of series the match was.
        /// </summary>
        [JsonPropertyName("series_type")]
        public long? SeriesType { get; set; }

        /// <summary>
        /// Gets or sets the number of kills the Radiant team had when the match ended.
        /// </summary>
        [JsonPropertyName("radiant_score")]
        public int RadiantScore { get; set; }

        /// <summary>
        /// Gets or sets the number of kills the Dire team had when the match ended.
        /// </summary>
        [JsonPropertyName("dire_score")]
        public int DireScore { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not the Radiant won the match.
        /// </summary>
        [JsonPropertyName("radiant_win")]
        public bool RadiantWin { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the team/player/hero was on Radiant.
        /// </summary>
        public bool Radiant { get; set; }
    }
}
