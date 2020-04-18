namespace OpenDotaDotNet.Models.Matches
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class MatchPlayer
    {
        // Match ID
        [JsonPropertyName("match_id")]
        public long MatchId { get; set; }

        // Which slot the player is in. 0-127 are Radiant, 128-255 are Dire
        [JsonPropertyName("player_slot")]
        public int PlayerSlot { get; set; }

        // TODO: Check if this actually works???
        // Object containing information on who the player used their abilities on
        [JsonPropertyName("ability_targets")]
        public Dictionary<string, Dictionary<string, int>> AbilityTargets { get; set; }

        // An array describing how abilities were upgraded
        [JsonPropertyName("ability_upgrades_arr")]
        public List<int> AbilityUpgradesArr { get; set; }

        // Object containing information on how many times the played used their abilities
        [JsonPropertyName("ability_uses")]
        public Dictionary<string, int> AbilityUses { get; set; }

        // Account ID
        [JsonPropertyName("account_id")]
        public long? AccountId { get; set; }

        // Object containing information on how many and what type of actions the player issued to their hero
        [JsonPropertyName("actions")]
        public Dictionary<string, long> Actions { get; set; }

        // Object containing information on additional units the player had under their control
        [JsonPropertyName("additional_units")]
        public List<AdditionalUnit> AdditionalUnits { get; set; }

        // Number of assists the player had
        [JsonPropertyName("assists")]
        public long Assists { get; set; }

        // Item in backpack slot 0
        [JsonPropertyName("backpack_0")]
        public long Backpack0 { get; set; }

        // Item in backpack slot 1
        [JsonPropertyName("backpack_1")]
        public long Backpack1 { get; set; }

        // Item in backpack slot 2
        [JsonPropertyName("backpack_2")]
        public long Backpack2 { get; set; }

        // Array containing information about buybacks
        [JsonPropertyName("buyback_log")]
        public List<BuybackLog> BuybackLogs { get; set; }

        // Number of camps stacked
        [JsonPropertyName("camps_stacked")]
        public int? CampsStacked { get; set; }

        [JsonPropertyName("connection_log")]
        public List<ConnectionLog> ConnectionLog { get; set; }

        // Number of creeps stacked
        [JsonPropertyName("creeps_stacked")]
        public int? CreepsStacked { get; set; }

        // Object containing information about damage dealt by the player to different units <unit,damage>
        [JsonPropertyName("damage")]
        public Dictionary<string, long> Damage { get; set; }

        // Object containing information about about the sources of this player's damage to heroes
        [JsonPropertyName("damage_inflictor")]
        public Dictionary<string, int> DamageInflictor { get; set; }

        // Object containing information about the sources of damage received by this player from heroes
        [JsonPropertyName("damage_inflictor_received")]
        public Dictionary<string, int> DamageInflictorReceived { get; set; }

        // Object containing information about from whom the player took damage
        [JsonPropertyName("damage_taken")]
        public Dictionary<string, int> DamageTaken { get; set; }

        // Object containing information on how and how much damage the player dealt to other heroes
        [JsonPropertyName("damage_targets")]
        public Dictionary<string, Dictionary<string, int>> DamageTargets { get; set; }

        // Number of deaths
        [JsonPropertyName("deaths")]
        public int Deaths { get; set; }

        // Number of denies
        [JsonPropertyName("denies")]
        public int Denies { get; set; }

        // Array containing number of denies at different times of the match
        [JsonPropertyName("dn_t")]
        public List<int> DeniesAtDifferentTimes { get; set; }

        // Indicates whether the player claimed first blood or not [might not be a bool?]
        [JsonPropertyName("firstblood_claimed")]
        public bool? FirstbloodClaimed { get; set; }

        // Gold at the end of the game
        [JsonPropertyName("gold")]
        public int Gold { get; set; }

        // Gold Per Minute obtained by this player
        [JsonPropertyName("gold_per_min")]
        public int GoldPerMin { get; set; }

        // Object containing information on how the player gainined gold over the course of the match
        [JsonPropertyName("gold_reasons")]
        public Dictionary<string, int> GoldReasons { get; set; }

        // How much gold the player spent
        [JsonPropertyName("gold_spent")]
        public int GoldSpent { get; set; }

        // Array containing total gold at different times of the match
        [JsonPropertyName("gold_t")]
        public List<long> GoldEachMinute { get; set; }

        // Hero Damage Dealt
        [JsonPropertyName("hero_damage")]
        public long HeroDamage { get; set; }

        // Hero Healing Done
        [JsonPropertyName("hero_healing")]
        public long HeroHealing { get; set; }

        // Object containing information on how many ticks of damages the hero inflicted with different spells and damage inflictors
        [JsonPropertyName("hero_hits")]
        public Dictionary<string, int> HeroHits { get; set; }

        // The ID value of the hero played
        [JsonPropertyName("hero_id")]
        public long HeroId { get; set; }

        // Item in the player's first slot
        [JsonPropertyName("item_0")]
        public long Item0 { get; set; }

        // Item in the player's second slot
        [JsonPropertyName("item_1")]
        public long Item1 { get; set; }

        // Item in the player's third slot
        [JsonPropertyName("item_2")]
        public long Item2 { get; set; }

        // Item in the player's fourth slot
        [JsonPropertyName("item_3")]
        public long Item3 { get; set; }

        // Item in the player's fifth slot
        [JsonPropertyName("item_4")]
        public long Item4 { get; set; }

        // Item in the player's sixth slot
        [JsonPropertyName("item_5")]
        public long Item5 { get; set; }

        // Object containing information about how many times a player used items
        [JsonPropertyName("item_uses")]
        public Dictionary<string, int> ItemUses { get; set; }

        // Object containing information about the player's killstreaks
        [JsonPropertyName("kill_streaks")]
        public Dictionary<string, int> KillStreaks { get; set; }

        // Object containing information about what units the player killed
        [JsonPropertyName("killed")]
        public Dictionary<string, int> UnitsKilled { get; set; }

        // Object containing information about who killed the player
        [JsonPropertyName("killed_by")]
        public Dictionary<string, int> KilledBy { get; set; }

        // Number of kills
        [JsonPropertyName("kills")]
        public long Kills { get; set; }

        // Array containing information on which hero the player killed at what time
        [JsonPropertyName("kills_log")]
        public List<KillLog> KillsLog { get; set; }

        // Object containing information on lane position
        [JsonPropertyName("lane_pos")]
        public Dictionary<string, Dictionary<string, int>> LanePos { get; set; }

        // Number of last hits
        [JsonPropertyName("last_hits")]
        public int LastHits { get; set; }

        // Integer describing whether or not the player left the game. 0: didn't leave. 1: left safely. 2+: Abandoned
        [JsonPropertyName("leaver_status")]
        public int LeaverStatus { get; set; }

        // Level at the end of the game
        [JsonPropertyName("level")]
        public int Level { get; set; }

        // Array describing last hits at each minute in the game
        [JsonPropertyName("lh_t")]
        public List<int> LastHitsEachMinute { get; set; }

        [JsonPropertyName("life_state")]
        public Dictionary<string, long> LifeState { get; set; }

        // Object with information on the highest damage instance the player inflicted
        [JsonPropertyName("max_hero_hit")]
        public MaxHeroHit MaxHeroHit { get; set; }

        // Object with information on the number of the number of multikills the player had
        [JsonPropertyName("multi_kills")]
        public Dictionary<string, int> MultiKills { get; set; }

        // Object with information on where the player placed observer wards. The location takes the form (outer number, inner number) and are from ~64-192.
        [JsonPropertyName("obs")]
        public Dictionary<string, Dictionary<string, int>> Obs { get; set; }

        [JsonPropertyName("obs_left_log")]
        public List<WardLog> ObsLeftLog { get; set; }

        // Object containing information on when and where the player placed observer wards
        [JsonPropertyName("obs_log")]
        public List<WardLog> ObsLog { get; set; }

        // Total number of observer wards placed
        [JsonPropertyName("obs_placed")]
        public int? ObsPlaced { get; set; }

        [JsonPropertyName("party_id")]
        public int PartyId { get; set; }

        // Size of the players party. If not in a party, will return 1.
        [JsonPropertyName("party_size")]
        public int PartySize { get; set; }

        // ???
        // [JsonPropertyName("performance_others")]
        // public object PerformanceOthers { get; set; }

        // Array describing permanent buffs the player had at the end of the game. List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/permanent_buffs.json
        [JsonPropertyName("permanent_buffs")]
        public List<PermanentBuff> PermanentBuffs { get; set; }

        // Total number of pings
        [JsonPropertyName("pings")]
        public int? Pings { get; set; }

        // Whether the player predicted victory
        [JsonPropertyName("pred_vict")]
        public bool? PredVict { get; set; }

        // Object containing information on the items the player purchased (item, times purchased)
        [JsonPropertyName("purchase")]
        public Dictionary<string, long?> Purchase { get; set; }

        // Object containing information on when items were purchased
        [JsonPropertyName("purchase_log")]
        public List<PurchaseLog> PurchaseLog { get; set; }

        // Whether the player randomed or not
        [JsonPropertyName("randomed")]
        public bool? Randomed { get; set; }

        // Whether the player repicked or not (no longer a thing?)
        [JsonPropertyName("repicked")]
        public bool? Repicked { get; set; }

        // Total number of roshan kills (last hit on roshan) the player had
        [JsonPropertyName("roshans_killed")]
        public int? RoshansKilled { get; set; }

        // Number of runes picked up
        [JsonPropertyName("rune_pickups")]
        public int? RunePickups { get; set; }

        // Object with information about which runes the player picked up
        [JsonPropertyName("runes")]
        public Dictionary<string, int> Runes { get; set; }

        // List with information on when runes were picked up
        [JsonPropertyName("runes_log")]
        public List<RuneLog> RuneLogs { get; set; }

        // Object with information on where sentries were placed. The location takes the form (outer number, inner number) and are from ~64-192.
        [JsonPropertyName("sen")]
        public Dictionary<string, Dictionary<string, int>> Sen { get; set; }

        // Array containing information on when and where the player placed sentries
        [JsonPropertyName("sen_left_log")]
        public List<WardLog> SenLeftLog { get; set; }

        // Array with information on when and where sentries were placed by the player
        [JsonPropertyName("sen_log")]
        public List<WardLog> SenLog { get; set; }

        // How many sentries were placed by the player
        [JsonPropertyName("sen_placed")]
        public int? SenPlaced { get; set; }

        // Total stun duration of all stuns by the player
        [JsonPropertyName("stuns")]
        public double? Stuns { get; set; }

        // Percentage of total teamfight participation by the player (value between 0-1)
        [JsonPropertyName("teamfight_participation")]
        public double? TeamfightParticipation { get; set; }

        // Time in seconds corresponding to the time of entries of other arrays in the match.
        [JsonPropertyName("times")]
        public List<int> Times { get; set; }

        // Total tower damage done by the player
        [JsonPropertyName("tower_damage")]
        public int TowerDamage { get; set; }

        // Total number of tower kills (last hit on tower) the player had
        [JsonPropertyName("towers_killed")]
        public int? TowersKilled { get; set; }

        // Experience Per Minute obtained by the player
        [JsonPropertyName("xp_per_min")]
        public int XpPerMin { get; set; }

        // Object containing information on the sources of this player's experience
        [JsonPropertyName("xp_reasons")]
        public Dictionary<string, int> XpReasons { get; set; }

        // Experience at each minute of the game
        [JsonPropertyName("xp_t")]
        public List<long> XpEachMinute { get; set; }

        [JsonPropertyName("personaname")]
        public string Personaname { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        // Time in seconds of last login of the player
        [JsonPropertyName("last_login")]
        public DateTimeOffset? LastLogin { get; set; }

        // Boolean indicating whether Radiant won the match
        [JsonPropertyName("radiant_win")]
        public bool RadiantWin { get; set; }

        // Start time of the match in seconds since 1970
        [JsonPropertyName("start_time")]
        public long StartTime { get; set; }

        // Duration of the game in seconds
        [JsonPropertyName("duration")]
        public int Duration { get; set; }

        [JsonPropertyName("cluster")]
        public long Cluster { get; set; }

        // Integer corresponding to lobby type of match. List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/lobby_type.json
        [JsonPropertyName("lobby_type")]
        public int LobbyType { get; set; }

        // Integer corresponding to game mode played. List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/game_mode.json
        [JsonPropertyName("game_mode")]
        public int GameMode { get; set; }

        // Whether the player is a contributor to OpenDota or not
        [JsonPropertyName("is_contributor")]
        public bool IsContributor { get; set; }

        // Integer representing the patch the game was played on
        [JsonPropertyName("patch")]
        public long Patch { get; set; }

        // Boolean for whether or not the player is on Radiant
        [JsonPropertyName("isRadiant")]
        public bool IsRadiant { get; set; }

        // Binary integer representing whether or not the player won
        [JsonPropertyName("win")]
        public int Win { get; set; }

        // Binary integer representing whether or not the player lost
        [JsonPropertyName("lose")]
        public int Lose { get; set; }

        // Total gold at the end of the game
        [JsonPropertyName("total_gold")]
        public long TotalGold { get; set; }

        // Total experience at the end of the game
        [JsonPropertyName("total_xp")]
        public long TotalXp { get; set; }

        // Number of kills per minute
        [JsonPropertyName("kills_per_min")]
        public double KillsPerMin { get; set; }

        // Kills deaths assists ratio (K+A)/D
        [JsonPropertyName("kda")]
        public long Kda { get; set; }

        // Abandons
        [JsonPropertyName("abandons")]
        public int Abandons { get; set; }

        // Total number of neutral creeps killed
        [JsonPropertyName("neutral_kills")]
        public int NeutralKills { get; set; }

        // Total number of tower kills the player had
        [JsonPropertyName("tower_kills")]
        public int TowerKills { get; set; }

        // Total number of courier kills the player had
        [JsonPropertyName("courier_kills")]
        public int CourierKills { get; set; }

        // Total number of lane creeps killed by the player
        [JsonPropertyName("lane_kills")]
        public int LaneKills { get; set; }

        // Total number of heroes killed by the player
        [JsonPropertyName("hero_kills")]
        public int HeroKills { get; set; }

        // Total number of observer wards killed by the player
        [JsonPropertyName("observer_kills")]
        public int ObserverKills { get; set; }

        // Total number of sentry wards killed by the player
        [JsonPropertyName("sentry_kills")]
        public int SentryKills { get; set; }

        // Total number of roshan kills (last hit on roshan) the player had
        [JsonPropertyName("roshan_kills")]
        public int RoshanKills { get; set; }

        // Total number of Necronomicon creeps killed by the player
        [JsonPropertyName("necronomicon_kills")]
        public int NecronomiconKills { get; set; }

        // Total number of Ancient creeps killed by the player
        [JsonPropertyName("ancient_kills")]
        public int AncientKills { get; set; }

        // Total number of buyback the player used
        [JsonPropertyName("buyback_count")]
        public int BuybackCount { get; set; }

        // Number of observer wards used
        [JsonPropertyName("observer_uses")]
        public int ObserverUses { get; set; }

        // Number of sentry wards used
        [JsonPropertyName("sentry_uses")]
        public int SentryUses { get; set; }

        // Lane efficiency of the player (value between 0-1)
        [JsonPropertyName("lane_efficiency")]
        public double LaneEfficiency { get; set; }

        // Percentage of lane efficiency (0-100)
        [JsonPropertyName("lane_efficiency_pct")]
        public int LaneEfficiencyPct { get; set; }

        // Integer referring to which lane the hero laned in
        [JsonPropertyName("lane")]
        public int Lane { get; set; }

        // Lane role
        [JsonPropertyName("lane_role")]
        public int LaneRole { get; set; }

        // Boolean referring to whether or not the player roamed
        [JsonPropertyName("is_roaming")]
        public bool IsRoaming { get; set; }

        // Object with information on when the player last purchased an item
        [JsonPropertyName("purchase_time")]
        public Dictionary<string, int?> PurchaseTime { get; set; }

        // Object with information on when the player first puchased an item
        [JsonPropertyName("first_purchase_time")]
        public Dictionary<string, int?> FirstPurchaseTime { get; set; }

        // Object with information on whether or not the item won
        [JsonPropertyName("item_win")]
        public Dictionary<string, int?> ItemWin { get; set; }

        // Object containing binary integers that tell whether the item was purchased by the player (note: this is always 1)
        [JsonPropertyName("item_usage")]
        public Dictionary<string, int?> ItemUsage { get; set; }

        // Total number of TP scrolls purchased by the player
        [JsonPropertyName("purchase_tpscroll")]
        public int PurchaseTpscroll { get; set; }

        // Actions per minute
        [JsonPropertyName("actions_per_min")]
        public int ActionsPerMin { get; set; }

        [JsonPropertyName("life_state_dead")]
        public int LifeStateDead { get; set; }

        // The rank tier of the player. Tens place indicates rank, ones place indicates stars.
        [JsonPropertyName("rank_tier")]
        public int? RankTier { get; set; }

        // Cosmetics
        [JsonPropertyName("cosmetics")]
        public List<Cosmetic> Cosmetics { get; set; }

        // Object containing information on certain benchmarks like GPM, XPM, KDA, tower damage, etc
        [JsonPropertyName("benchmarks")]
        public MatchPlayerBenchmarks Benchmarks { get; set; }

        // Total amount of observer wards purchased by the player
        [JsonPropertyName("purchase_ward_observer")]
        public long? PurchaseWardObserver { get; set; }

        // Total amount of sentry wards purchased by the player
        [JsonPropertyName("purchase_ward_sentry")]
        public long? PurchaseWardSentry { get; set; }

        // Total amount of gems purchased by the player
        [JsonPropertyName("purchase_gem")]
        public long? PurchaseGem { get; set; }
    }
}
