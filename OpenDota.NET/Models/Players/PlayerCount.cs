namespace OpenDotaDotNet.Models.Players
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class PlayerCount
    {
        /// <summary>
        /// Gets or sets integer describing whether or not the player left the game. 0: didn't leave. 1: left safely. 2+: Abandoned.
        /// </summary>
        [JsonProperty("leaver_status")]
        public Dictionary<string, PlayerCountStats> LeaverStatus { get; set; }

        /// <summary>
        /// Gets or sets integer corresponding to game mode played.
        /// List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/game_mode.json.
        /// </summary>
        [JsonProperty("game_mode")]
        public Dictionary<string, PlayerCountStats> GameMode { get; set; }

        /// <summary>
        /// Gets or sets integer corresponding to lobby type of match.
        /// List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/lobby_type.json.
        /// </summary>
        [JsonProperty("lobby_type")]
        public Dictionary<string, PlayerCountStats> LobbyType { get; set; }

        /// <summary>
        /// Gets or sets lane_role.
        /// </summary>
        [JsonProperty("lane_role")]
        public Dictionary<string, PlayerCountStats> LaneRole { get; set; }

        /// <summary>
        /// Gets or sets integer corresponding to the region the game was played on.
        /// </summary>
        [JsonProperty("region")]
        public Dictionary<string, PlayerCountStats> Region { get; set; }

        /// <summary>
        /// Gets or sets patch.
        /// </summary>
        [JsonProperty("patch")]
        public Dictionary<string, PlayerCountStats> Patch { get; set; }

        /// <summary>
        /// Gets or sets radiant/dire stats.
        /// </summary>
        [JsonProperty("is_radiant")]
        public Dictionary<string, PlayerCountStats> IsRadiant { get; set; }
    }
}
