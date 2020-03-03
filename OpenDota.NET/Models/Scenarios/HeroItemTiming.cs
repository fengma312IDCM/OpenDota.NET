namespace OpenDotaDotNet.Models.Scenarios
{
    using System.Text.Json.Serialization;

    public class HeroItemTiming
    {
        [JsonPropertyName("hero_id")]
        public int HeroId { get; set; }

        [JsonPropertyName("item")]
        public string Item { get; set; }

        [JsonPropertyName("time")]
        public int Time { get; set; }

        [JsonPropertyName("games")]
        public int Games { get; set; }

        [JsonPropertyName("wins")]
        public int Wins { get; set; }
    }
}
