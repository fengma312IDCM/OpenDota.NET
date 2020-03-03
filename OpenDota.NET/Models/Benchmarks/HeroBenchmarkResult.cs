namespace OpenDotaDotNet.Models.Benchmarks
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class HeroBenchmarkResult
    {
        [JsonPropertyName("gold_per_min")]
        public List<HeroBenchmarkValue> GoldPerMin { get; set; }

        [JsonPropertyName("xp_per_min")]
        public List<HeroBenchmarkValue> XpPerMin { get; set; }

        [JsonPropertyName("kills_per_min")]
        public List<HeroBenchmarkValue> KillsPerMin { get; set; }

        [JsonPropertyName("last_hits_per_min")]
        public List<HeroBenchmarkValue> LastHitsPerMin { get; set; }

        [JsonPropertyName("hero_damage_per_min")]
        public List<HeroBenchmarkValue> HeroDamagePerMin { get; set; }

        [JsonPropertyName("hero_healing_per_min")]
        public List<HeroBenchmarkValue> HeroHealingPerMin { get; set; }

        [JsonPropertyName("tower_damage")]
        public List<HeroBenchmarkValue> TowerDamage { get; set; }

        [JsonPropertyName("stuns_per_min")]
        public List<HeroBenchmarkValue> StunsPerMin { get; set; }

        [JsonPropertyName("lhten")]
        public List<HeroBenchmarkValue> Lhten { get; set; }
    }
}
