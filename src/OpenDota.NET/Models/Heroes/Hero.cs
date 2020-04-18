namespace OpenDotaDotNet.Models.Heroes
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class Hero
    {
        /// <summary>
        /// Gets or sets numeric identifier for the hero object.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets dota hero command name, e.g. 'npc_dota_hero_antimage'.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets hero name, e.g. 'Anti-Mage'.
        /// </summary>
        [JsonPropertyName("localized_name")]
        public string LocalizedName { get; set; }

        /// <summary>
        /// Gets or sets hero primary shorthand attribute name, e.g. 'agi'.
        /// </summary>
        [JsonPropertyName("primary_attr")]
        public HeroPrimaryAttribute PrimaryAttribute { get; set; }

        /// <summary>
        /// Gets or sets hero attack type, either 'Melee' or 'Ranged'.
        /// </summary>
        [JsonPropertyName("attack_type")]
        public HeroAttackType AttackType { get; set; }

        /// <summary>
        /// Gets or sets hero's role in the game.
        /// </summary>
        [JsonPropertyName("roles")]
        public IEnumerable<HeroRole> Roles { get; set; }

        /// <summary>
        /// Gets or sets hero's amount of legs.
        /// </summary>
        [JsonPropertyName("legs")]
        public int Legs { get; set; }
    }
}
