namespace OpenDotaDotNet.Models.Records
{
    // TODO: Convert to enumeration
    public class RecordField
    {
        private RecordField(string value)
        {
            this.Value = value;
        }

        public static RecordField Duration => new RecordField("duration");

        public static RecordField Kills => new RecordField("kills");

        public static RecordField Deaths => new RecordField("deaths");

        public static RecordField Assists => new RecordField("assists");

        public static RecordField GoldPerMin => new RecordField("gold_per_min");

        public static RecordField XpPerMin => new RecordField("xp_per_min");

        public static RecordField LastHits => new RecordField("last_hits");

        public static RecordField Denies => new RecordField("denies");

        public static RecordField HeroDamage => new RecordField("hero_damage");

        public static RecordField TowerDamage => new RecordField("tower_damage");

        public static RecordField HeroHealing => new RecordField("hero_healing");

        public string Value { get; set; }
    }
}
