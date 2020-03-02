namespace OpenDotaDotNet.Models.Heroes
{
    using Newtonsoft.Json;

    public class HeroPlayer
    {
        /// <summary>
        /// Gets or sets player's account identifier.
        /// </summary>
        [JsonProperty("account_id")]
        public long AccountId { get; set; }

        /// <summary>
        /// Gets or sets number of games played on the hero.
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
