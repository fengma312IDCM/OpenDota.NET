namespace OpenDotaDotNet.Models.Rankings
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class HeroRanking
    {
        [JsonProperty("hero_id")]
        public long HeroId { get; set; }

        [JsonProperty("rankings")]
        public List<RankingPlayer> Rankings { get; set; }
    }
}
