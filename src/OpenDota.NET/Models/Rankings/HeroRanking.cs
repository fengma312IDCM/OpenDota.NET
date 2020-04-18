namespace OpenDotaDotNet.Models.Rankings
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class HeroRanking
    {
        [JsonPropertyName("hero_id")]
        public long HeroId { get; set; }

        [JsonPropertyName("rankings")]
        public IEnumerable<RankingPlayer> Rankings { get; set; }
    }
}
