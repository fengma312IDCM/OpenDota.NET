namespace OpenDotaDotNet.Models.Matches
{
    using System.Text.Json.Serialization;

    public class MaxHeroHit
    {
        // max_hero_hit
        [JsonPropertyName("type")]
        public string Type { get; set; }

        // Time (in seconds) when the hit occurred
        [JsonPropertyName("time")]
        public int Time { get; set; }

        // Whether it was a max hero hit (should be true)
        [JsonPropertyName("max")]
        public bool Max { get; set; }

        // The inflictor of the hit
        [JsonPropertyName("inflictor")]
        public string Inflictor { get; set; }

        // The unit which inflicted the hit
        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        // The unit to which it was inflicted
        [JsonPropertyName("key")]
        public string Key { get; set; }

        // Damage inflicted
        [JsonPropertyName("value")]
        public long Value { get; set; }

        // Slot
        [JsonPropertyName("slot")]
        public long Slot { get; set; }

        // Slot of player
        [JsonPropertyName("player_slot")]
        public long PlayerSlot { get; set; }
    }
}
