namespace OpenDotaDotNet.Models.Matches
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class TeamfightPlayer
    {
        // Position where the hero died? Only has value if deaths is greater than 0
        [JsonPropertyName("deaths_pos")]
        public Dictionary<string, Dictionary<string, int>> DeathsPos { get; set; }

        // The name of abilities used and how many times they were used
        [JsonPropertyName("ability_uses")]
        public Dictionary<string, int> AbilityUses { get; set; }

        // NOTE: No value is returned for this param
        // [JsonPropertyName("ability_targets")]
        // public MyWordCounts AbilityTargets { get; set; }

        // The name of items used and how many times they were used
        [JsonPropertyName("item_uses")]
        public Dictionary<string, long> ItemUses { get; set; }

        // The heroes killed and how many times they were killed
        [JsonPropertyName("killed")]
        public Dictionary<string, long> Killed { get; set; }

        // How many deaths the player got during the teamfight
        [JsonPropertyName("deaths")]
        public long Deaths { get; set; }

        // If the player bought back or not
        [JsonPropertyName("buybacks")]
        public long Buybacks { get; set; }

        // Total amount of damage
        [JsonPropertyName("damage")]
        public long Damage { get; set; }

        // Total amount of healing
        [JsonPropertyName("healing")]
        public long Healing { get; set; }

        // Gold gained from the teamfight
        [JsonPropertyName("gold_delta")]
        public long GoldDelta { get; set; }

        // Experience gained from the teamfight
        [JsonPropertyName("xp_delta")]
        public long XpDelta { get; set; }

        [JsonPropertyName("xp_start")]
        public long XpStart { get; set; }

        [JsonPropertyName("xp_end")]
        public long XpEnd { get; set; }
    }
}
