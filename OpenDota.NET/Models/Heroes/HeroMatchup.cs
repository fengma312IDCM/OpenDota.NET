namespace OpenDotaDotNet.Models.Heroes
{
    using Newtonsoft.Json;

    public class HeroMatchup
    {
        /// <summary>
        /// Gets or sets numeric identifier for the hero object.
        /// </summary>
        [JsonProperty("hero_id")]
        public long HeroId { get; set; }

        /// <summary>
        /// Gets or sets number of games played.
        /// </summary>
        [JsonProperty("games_played")]
        public long GamesPlayed { get; set; }

        /// <summary>
        /// Gets or sets number of games won.
        /// </summary>
        [JsonProperty("wins")]
        public long Wins { get; set; }
    }
}
