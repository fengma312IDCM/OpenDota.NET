namespace OpenDotaDotNet.Models.Rankings
{
    using System;

    using Newtonsoft.Json;

    public class RankingPlayer
    {
        [JsonProperty("account_id")]
        public long AccountId { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("personaname")]
        public string Personaname { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("avatar")]
        public Uri Avatar { get; set; }

        [JsonProperty("last_login")]
        public DateTimeOffset? LastLogin { get; set; }

        [JsonProperty("rank_tier")]
        public int? RankTier { get; set; }
    }
}
