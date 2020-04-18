namespace OpenDotaDotNet.Models.Benchmarks
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class HeroBenchmarkResult
    {
        /// <summary>
        /// Gets or sets the gold per minute benchmarks.
        /// </summary>
        [JsonPropertyName("gold_per_min")]
        public IEnumerable<HeroBenchmarkValue> GoldPerMin { get; set; }

        /// <summary>
        /// Gets or sets the experience per minute benchmarks.
        /// </summary>
        [JsonPropertyName("xp_per_min")]
        public IEnumerable<HeroBenchmarkValue> XpPerMin { get; set; }

        /// <summary>
        /// Gets or sets the kills per minute benchmarks.
        /// </summary>
        [JsonPropertyName("kills_per_min")]
        public IEnumerable<HeroBenchmarkValue> KillsPerMin { get; set; }

        /// <summary>
        /// Gets or sets the last hits per minute benchmarks.
        /// </summary>
        [JsonPropertyName("last_hits_per_min")]
        public IEnumerable<HeroBenchmarkValue> LastHitsPerMin { get; set; }

        /// <summary>
        /// Gets or sets the hero damage per minute benchmarks.
        /// </summary>
        [JsonPropertyName("hero_damage_per_min")]
        public IEnumerable<HeroBenchmarkValue> HeroDamagePerMin { get; set; }

        /// <summary>
        /// Gets or sets the hero healing per minute benchmarks.
        /// </summary>
        [JsonPropertyName("hero_healing_per_min")]
        public IEnumerable<HeroBenchmarkValue> HeroHealingPerMin { get; set; }

        /// <summary>
        /// Gets or sets the tower damage benchmarks.
        /// </summary>
        [JsonPropertyName("tower_damage")]
        public IEnumerable<HeroBenchmarkValue> TowerDamage { get; set; }

        /// <summary>
        /// Gets or sets the stuns per minute benchmarks.
        /// </summary>
        [JsonPropertyName("stuns_per_min")]
        public IEnumerable<HeroBenchmarkValue> StunsPerMin { get; set; }

        /// <summary>
        /// Gets or sets last hits at minute 10.
        /// </summary>
        [JsonPropertyName("lhten")]
        public IEnumerable<HeroBenchmarkValue> LastHits10Minute { get; set; }
    }
}
