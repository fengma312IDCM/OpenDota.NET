namespace OpenDotaDotNet.Models.Heroes
{
    using System.Text.Json.Serialization;

    public class HeroPlayer
    {
        /// <summary>
        /// Gets or sets player's account identifier.
        /// </summary>
        [JsonPropertyName("account_id")]
        public long AccountId { get; set; }

        /// <summary>
        /// Gets or sets number of games played on the hero.
        /// </summary>
        [JsonPropertyName("games_played")]
        public long GamesPlayed { get; set; }

        /// <summary>
        /// Gets or sets number of games won.
        /// </summary>
        [JsonPropertyName("wins")]
        public long Wins { get; set; }
    }
}
