namespace OpenDotaDotNet.Models.ProMatches
{
    using Newtonsoft.Json;

    public class ProMatch
    {
        /// <summary>
        /// Gets or sets ID used to identify individual matches, e.g. 3703866531.
        /// </summary>
        [JsonProperty("match_id")]
        public long MatchId { get; set; }

        /// <summary>
        /// Gets or sets length of the match.
        /// </summary>
        [JsonProperty("duration")]
        public int Duration { get; set; }

        /// <summary>
        /// Gets or sets Unix timestamp of when the match began.
        /// </summary>
        [JsonProperty("start_time")]
        public long StartTime { get; set; }

        /// <summary>
        /// Gets or sets the Radiant's team_id.
        /// </summary>
        [JsonProperty("radiant_team_id")]
        public long? RadiantTeamId { get; set; }

        /// <summary>
        /// Gets or sets the Radiant's team name.
        /// </summary>
        [JsonProperty("radiant_name")]
        public string RadiantName { get; set; }

        /// <summary>
        /// Gets or sets the Dire's team_id.
        /// </summary>
        [JsonProperty("dire_team_id")]
        public long? DireTeamId { get; set; }

        /// <summary>
        /// Gets or sets the Dire's team name.
        /// </summary>
        [JsonProperty("dire_name")]
        public string DireName { get; set; }

        /// <summary>
        /// Gets or sets identifier for the league the match took place in.
        /// </summary>
        [JsonProperty("leagueid")]
        public long LeagueId { get; set; }

        /// <summary>
        /// Gets or sets name of league the match took place in.
        /// </summary>
        [JsonProperty("league_name")]
        public string LeagueName { get; set; }

        /// <summary>
        /// Gets or sets identifier for the series of the match.
        /// </summary>
        [JsonProperty("series_id")]
        public long? SeriesId { get; set; }

        /// <summary>
        /// Gets or sets type of series the match was.
        /// </summary>
        [JsonProperty("series_type")]
        public long? SeriesType { get; set; }

        /// <summary>
        /// Gets or sets the number of kills the Radiant team had when the match ended.
        /// </summary>
        [JsonProperty("radiant_score")]
        public int RadiantScore { get; set; }

        /// <summary>
        /// Gets or sets the number of kills the Dire team had when the match ended.
        /// </summary>
        [JsonProperty("dire_score")]
        public int DireScore { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not the Radiant won the match.
        /// </summary>
        [JsonProperty("radiant_win")]
        public bool RadiantWin { get; set; }
    }
}
