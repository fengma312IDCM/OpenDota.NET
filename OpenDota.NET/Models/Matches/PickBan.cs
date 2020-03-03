namespace OpenDotaDotNet.Models.Matches
{
    using System.Text.Json.Serialization;

    public class PickBan
    {
        // Whether it was picked or banned. False means the hero was banned, true means the hero was picked.
        [JsonPropertyName("is_pick")]
        public bool IsPick { get; set; }

        // Id of the hero picked or banned
        [JsonPropertyName("hero_id")]
        public int HeroId { get; set; }

        // Team that picked or banned the hero
        [JsonPropertyName("team")]
        public int Team { get; set; }

        // Order of pick or ban
        [JsonPropertyName("order")]
        public int Order { get; set; }

        // Order of pick or ban (from what ive seen its the same value as above always)
        [JsonPropertyName("ord")]
        public long Ord { get; set; }

        // Match id
        [JsonPropertyName("match_id")]
        public long MatchId { get; set; }
    }
}
