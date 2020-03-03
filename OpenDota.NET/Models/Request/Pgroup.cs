namespace OpenDotaDotNet.Models.Request
{
    using System.Text.Json.Serialization;

    public class Pgroup
    {
        [JsonPropertyName("account_id")]
        public long? AccountId { get; set; }

        [JsonPropertyName("hero_id")]
        public int HeroId { get; set; }

        [JsonPropertyName("player_slot")]
        public int PlayerSlot { get; set; }
    }
}
