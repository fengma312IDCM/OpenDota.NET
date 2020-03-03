namespace OpenDotaDotNet.Models.Players
{
    using System.Text.Json.Serialization;

    public class PlayerMatchHero
    {
        [JsonPropertyName("account_id")]
        public long? AccountId { get; set; }

        [JsonPropertyName("hero_id")]
        public long HeroId { get; set; }

        [JsonPropertyName("player_slot")]
        public long PlayerSlot { get; set; }
    }
}
