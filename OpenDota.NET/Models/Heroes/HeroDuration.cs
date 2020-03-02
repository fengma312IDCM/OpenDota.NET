namespace OpenDotaDotNet.Models.Heroes
{
    using Newtonsoft.Json;

    public class HeroDuration
    {
        /// <summary>
        /// Gets or sets lower bound of number of seconds the match lasted.
        /// </summary>
        [JsonProperty("duration_bin")]
        public int DurationBin { get; set; }

        /// <summary>
        /// Gets or sets number of games played.
        /// </summary>
        [JsonProperty("games_played")]
        public int GamesPlayed { get; set; }

        /// <summary>
        /// Gets or sets number of wins.
        /// </summary>
        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}
