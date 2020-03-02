namespace OpenDotaDotNet.Models.Players
{
    using Newtonsoft.Json;

    public class PlayerHeroRanking
    {
        [JsonProperty("hero_id")]
        public long HeroId { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("percent_rank")]
        public double PercentRank { get; set; }

        [JsonProperty("card")]
        public long Card { get; set; }
    }
}
