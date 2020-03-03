namespace OpenDotaDotNet.Models.Players
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PlayerMatch
    {
        // Match ID
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

        // Time the game started in seconds since 1970
        [JsonPropertyName("start_time")]
        public long StartTime { get; set; }

        // Version
        [JsonPropertyName("version")]
        public int? Version { get; set; }

        // Total kills the player had at the end of the game
        [JsonPropertyName("kills")]
        public int Kills { get; set; }

        // Total deaths the player had at the end of the game
        [JsonPropertyName("deaths")]
        public int Deaths { get; set; }

        // Total assists the player had at the end of the game
        [JsonPropertyName("assists")]
        public int Assists { get; set; }

        // Skill bracket assigned by Valve (Normal, High, Very High)
        [JsonPropertyName("skill")]
        public int? Skill { get; set; }

        // Integer describing whether or not the player left the game. 0: didn't leave. 1: left safely. 2+: Abandoned
        [JsonPropertyName("leaver_status")]
        public int LeaverStatus { get; set; }

        // Size of the player's party
        [JsonPropertyName("party_size")]
        public int? PartySize { get; set; }

        // Heroes (requires ?project=heroes)
        [JsonPropertyName("heroes")]
        public Dictionary<string, PlayerMatchHero> Heroes { get; set; }
    }
}
