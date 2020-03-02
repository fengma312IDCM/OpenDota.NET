namespace OpenDotaDotNet.Models.Request
{
    using Newtonsoft.Json;

    public class Pgroup
    {
        [JsonProperty("account_id")]
        public long? AccountId { get; set; }

        [JsonProperty("hero_id")]
        public int HeroId { get; set; }

        [JsonProperty("player_slot")]
        public int PlayerSlot { get; set; }
    }
}
