namespace OpenDotaDotNet.Models.Players
{
    using System.Text.Json.Serialization;

    public class PlayerRecentMatch
    {
        // The ID of the match
        [JsonPropertyName("match_id")]
        public long MatchId { get; set; }

        // Which slot the player is in. 0-127 are Radiant, 128-255 are Dire
        [JsonPropertyName("player_slot")]
        public int PlayerSlot { get; set; }

        // Boolean indicating whether Radiant won the match
        [JsonPropertyName("radiant_win")]
        public bool RadiantWin { get; set; }

        // Duration of the game in seconds
        [JsonPropertyName("duration")]
        public int Duration { get; set; }

        // Integer corresponding to game mode played. List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/game_mode.json
        [JsonPropertyName("game_mode")]
        public int GameMode { get; set; }

        // Integer corresponding to lobby type of match. List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/lobby_type.json
        [JsonPropertyName("lobby_type")]
        public int LobbyType { get; set; }

        // The ID value of the hero played
        [JsonPropertyName("hero_id")]
        public int HeroId { get; set; }

        // Start time of the match in seconds elapsed since 1970
        [JsonPropertyName("start_time")]
        public long StartTime { get; set; }

        // version
        [JsonPropertyName("version")]
        public long? Version { get; set; }

        // Total kills the player had at the end of the match
        [JsonPropertyName("kills")]
        public int Kills { get; set; }

        // Total deaths the player had at the end of the match
        [JsonPropertyName("deaths")]
        public int Deaths { get; set; }

        // Total assists the player had at the end of the match
        [JsonPropertyName("assists")]
        public int Assists { get; set; }

        // Skill bracket assigned by Valve (Normal, High, Very High)
        [JsonPropertyName("skill")]
        public int? Skill { get; set; }

        // Average experience per minute
        [JsonPropertyName("xp_per_min")]
        public int XpPerMin { get; set; }

        // Average gold per minute
        [JsonPropertyName("gold_per_min")]
        public int GoldPerMin { get; set; }

        // Total amount of hero damage dealt by the player
        [JsonPropertyName("hero_damage")]
        public int HeroDamage { get; set; }

        // Total amount of tower damage dealt by the player
        [JsonPropertyName("tower_damage")]
        public int TowerDamage { get; set; }

        // Total amount of healing provided by the player
        [JsonPropertyName("hero_healing")]
        public int HeroHealing { get; set; }

        // Total amounts of last hits
        [JsonPropertyName("last_hits")]
        public int LastHits { get; set; }

        // Integer corresponding to which lane the player laned in for the match
        [JsonPropertyName("lane")]
        public int? Lane { get; set; }

        // lane_role
        [JsonPropertyName("lane_role")]
        public int? LaneRole { get; set; }

        // Boolean describing whether or not the player roamed
        [JsonPropertyName("is_roaming")]
        public bool? IsRoaming { get; set; }

        // cluster
        [JsonPropertyName("cluster")]
        public int Cluster { get; set; }

        // Integer describing whether or not the player left the game. 0: didn't leave. 1: left safely. 2+: Abandoned
        [JsonPropertyName("leaver_status")]
        public int LeaverStatus { get; set; }

        // Size of the players party. If not in a party, will return 1.
        [JsonPropertyName("party_size")]
        public long? PartySize { get; set; }
    }
}
