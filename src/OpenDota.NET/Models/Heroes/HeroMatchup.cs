namespace OpenDotaDotNet.Models.Heroes
{
    using System.Text.Json.Serialization;

    public class HeroMatchup
    {
        /// <summary>
        /// Gets or sets numeric identifier for the hero object.
        /// </summary>
        [JsonPropertyName("hero_id")]
        public long HeroId { get; set; }

        /// <summary>
        /// Gets or sets number of games played.
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
