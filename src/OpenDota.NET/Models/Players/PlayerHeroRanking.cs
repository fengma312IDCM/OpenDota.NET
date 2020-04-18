namespace OpenDotaDotNet.Models.Players
{
    using System.Text.Json.Serialization;

    public class PlayerHeroRanking
    {
        [JsonPropertyName("hero_id")]
        public long HeroId { get; set; }

        [JsonPropertyName("score")]
        public double Score { get; set; }

        [JsonPropertyName("percent_rank")]
        public double PercentRank { get; set; }

        [JsonPropertyName("card")]
        public long Card { get; set; }
    }
}
