namespace OpenDotaDotNet.Models.Heroes
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class Hero
    {
        /// <summary>
        /// Numeric identifier for the hero object
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Dota hero command name, e.g. 'npc_dota_hero_antimage'
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Hero name, e.g. 'Anti-Mage'
        /// </summary>
        [JsonPropertyName("localized_name")]
        public string LocalizedName { get; set; }

        /// <summary>
        /// Hero primary shorthand attribute name, e.g. 'agi'
        /// </summary>
        [JsonPropertyName("primary_attr")]
        public HeroPrimaryAttribute PrimaryAttribute { get; set; }

        /// <summary>
        /// Hero attack type, either 'Melee' or 'Ranged'
        /// </summary>
        [JsonPropertyName("attack_type")]
        public HeroAttackType AttackType { get; set; }

        /// <summary>
        /// A hero's role in the game
        /// </summary>
        [JsonPropertyName("roles")]
        public List<HeroRole> Roles { get; set; }

        /// <summary>
        /// A hero's amount of legs
        /// </summary>
        [JsonPropertyName("legs")]
        public int Legs { get; set; }
    }
}
