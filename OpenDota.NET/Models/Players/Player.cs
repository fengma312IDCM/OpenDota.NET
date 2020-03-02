namespace OpenDotaDotNet.Models.Players
{
    using Newtonsoft.Json;

    public class Player
    {
        [JsonProperty("tracked_until")]
        public string TrackedUntil { get; set; }

        [JsonProperty("solo_competitive_rank")]
        public string SoloCompetitiveRank { get; set; }

        [JsonProperty("competitive_rank")]
        public string CompetitiveRank { get; set; }

        [JsonProperty("rank_tier")]
        public int? RankTier { get; set; }

        [JsonProperty("leaderboard_rank")]
        public int? LeaderboardRank { get; set; }

        [JsonProperty("mmr_estimate")]
        public MmrEstimate MmrEstimate { get; set; }

        [JsonProperty("profile")]
        public Profile Profile { get; set; }
    }
}
