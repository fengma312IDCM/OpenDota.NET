namespace OpenDotaDotNet.Models.HeroStats
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    using OpenDotaDotNet.Models.Heroes;

    public class HeroStats
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("localized_name")]
        public string LocalizedName { get; set; }

        [JsonPropertyName("primary_attr")]
        public HeroPrimaryAttribute PrimaryAttr { get; set; }

        [JsonPropertyName("attack_type")]
        public HeroAttackType AttackType { get; set; }

        [JsonPropertyName("roles")]
        public List<HeroRole> Roles { get; set; }

        [JsonPropertyName("img")]
        public string Img { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("base_health")]
        public int BaseHealth { get; set; }

        [JsonPropertyName("base_health_regen")]
        public double? BaseHealthRegen { get; set; }

        [JsonPropertyName("base_mana")]
        public int BaseMana { get; set; }

        [JsonPropertyName("base_mana_regen")]
        public double BaseManaRegen { get; set; }

        [JsonPropertyName("base_armor")]
        public double BaseArmor { get; set; }

        [JsonPropertyName("base_mr")]
        public int BaseMr { get; set; }

        [JsonPropertyName("base_attack_min")]
        public int BaseAttackMin { get; set; }

        [JsonPropertyName("base_attack_max")]
        public int BaseAttackMax { get; set; }

        [JsonPropertyName("base_str")]
        public int BaseStr { get; set; }

        [JsonPropertyName("base_agi")]
        public int BaseAgi { get; set; }

        [JsonPropertyName("base_int")]
        public int BaseInt { get; set; }

        [JsonPropertyName("str_gain")]
        public double StrGain { get; set; }

        [JsonPropertyName("agi_gain")]
        public double AgiGain { get; set; }

        [JsonPropertyName("int_gain")]
        public double IntGain { get; set; }

        [JsonPropertyName("attack_range")]
        public int AttackRange { get; set; }

        [JsonPropertyName("projectile_speed")]
        public int ProjectileSpeed { get; set; }

        [JsonPropertyName("attack_rate")]
        public double AttackRate { get; set; }

        [JsonPropertyName("move_speed")]
        public int MoveSpeed { get; set; }

        [JsonPropertyName("turn_rate")]
        public double TurnRate { get; set; }

        [JsonPropertyName("cm_enabled")]
        public bool CmEnabled { get; set; }

        [JsonPropertyName("legs")]
        public int Legs { get; set; }

        [JsonPropertyName("pro_ban")]
        public int ProBan { get; set; }

        [JsonPropertyName("hero_id")]
        public int HeroId { get; set; }

        [JsonPropertyName("pro_win")]
        public int ProWin { get; set; }

        [JsonPropertyName("pro_pick")]
        public int ProPick { get; set; }

        [JsonPropertyName("1_pick")]
        public int The1_Pick { get; set; }

        [JsonPropertyName("1_win")]
        public int The1_Win { get; set; }

        [JsonPropertyName("2_pick")]
        public int The2_Pick { get; set; }

        [JsonPropertyName("2_win")]
        public int The2_Win { get; set; }

        [JsonPropertyName("3_pick")]
        public int The3_Pick { get; set; }

        [JsonPropertyName("3_win")]
        public int The3_Win { get; set; }

        [JsonPropertyName("4_pick")]
        public int The4_Pick { get; set; }

        [JsonPropertyName("4_win")]
        public int The4_Win { get; set; }

        [JsonPropertyName("5_pick")]
        public int The5_Pick { get; set; }

        [JsonPropertyName("5_win")]
        public int The5_Win { get; set; }

        [JsonPropertyName("6_pick")]
        public int The6_Pick { get; set; }

        [JsonPropertyName("6_win")]
        public int The6_Win { get; set; }

        [JsonPropertyName("7_pick")]
        public int The7_Pick { get; set; }

        [JsonPropertyName("7_win")]
        public int The7_Win { get; set; }

        [JsonPropertyName("8_pick")]
        public int The8_Pick { get; set; }

        [JsonPropertyName("8_win")]
        public int The8_Win { get; set; }

        [JsonPropertyName("null_pick")]
        public long NullPick { get; set; }

        [JsonPropertyName("null_win")]
        public long NullWin { get; set; }
    }
}
