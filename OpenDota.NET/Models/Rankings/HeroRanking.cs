namespace OpenDotaDotNet.Models.Rankings
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class HeroRanking
    {
        [JsonPropertyName("hero_id")]
        public long HeroId { get; set; }

        [JsonPropertyName("rankings")]
        public List<RankingPlayer> Rankings { get; set; }
    }
}
