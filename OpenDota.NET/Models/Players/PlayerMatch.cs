namespace OpenDotaDotNet.Models.Players
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PlayerMatch
    {
        /// <summary>
        /// Gets or sets the match ID.
        /// </summary>
        [JsonPropertyName("match_id")]
        public long MatchId { get; set; }

        /// <summary>
        /// Gets or sets which slot the player is in. 0-127 are Radiant, 128-255 are Dire.
        /// </summary>
        [JsonPropertyName("player_slot")]
        public int PlayerSlot { get; set; }

        /// <summary>
        /// Gets or sets whether Radiant won the match.
        /// </summary>
        [JsonPropertyName("radiant_win")]
        public bool? RadiantWin { get; set; }

        /// <summary>
        /// Gets or sets the duration of the game in seconds.
        /// </summary>
        [JsonPropertyName("duration")]
        public int Duration { get; set; }

        /// <summary>
        /// Gets or sets an integer corresponding to game mode played.
        /// List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/game_mode.json.
        /// </summary>
        [JsonPropertyName("game_mode")]
        public int GameMode { get; set; }

        /// <summary>
        /// Gets or sets an integer corresponding to lobby type of match.
        /// List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/lobby_type.json.
        /// </summary>
        [JsonPropertyName("lobby_type")]
        public int LobbyType { get; set; }

        /// <summary>
        /// Gets or sets the ID value of the hero played.
        /// </summary>
        [JsonPropertyName("hero_id")]
        public int HeroId { get; set; }

        /// <summary>
        /// Gets or sets time the game started in seconds since 1970.
        /// </summary>
        [JsonPropertyName("start_time")]
        public long StartTime { get; set; }

        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        [JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Gets or sets total kills the player had at the end of the game.
        /// </summary>
        [JsonPropertyName("kills")]
        public int Kills { get; set; }

        /// <summary>
        /// Gets or sets total deaths the player had at the end of the game.
        /// </summary>
        [JsonPropertyName("deaths")]
        public int Deaths { get; set; }

        /// <summary>
        /// Gets or sets total assists the player had at the end of the game.
        /// </summary>
        [JsonPropertyName("assists")]
        public int Assists { get; set; }

        /// <summary>
        /// Gets or sets skill bracket assigned by Valve (Normal, High, Very High).
        /// </summary>
        [JsonPropertyName("skill")]
        public int? Skill { get; set; }

        /// <summary>
        /// Gets or sets integer describing whether or not the player left the game. 0: didn't leave. 1: left safely. 2+: Abandoned.
        /// </summary>
        [JsonPropertyName("leaver_status")]
        public int LeaverStatus { get; set; }

        /// <summary>
        /// Gets or sets size of the player's party.
        /// </summary>
        [JsonPropertyName("party_size")]
        public int? PartySize { get; set; }

        /// <summary>
        /// Gets or sets the heroes.
        /// (requires ?project=heroes).
        /// </summary>
        [JsonPropertyName("heroes")]
        public Dictionary<string, PlayerMatchHero> Heroes { get; set; }
    }
}
