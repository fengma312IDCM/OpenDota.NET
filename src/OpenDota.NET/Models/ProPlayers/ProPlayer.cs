namespace OpenDotaDotNet.Models.ProPlayers
{
    using System;
    using System.Text.Json.Serialization;

    public class ProPlayer
    {
        /// <summary>
        /// Gets or sets player's account identifier.
        /// </summary>
        [JsonPropertyName("account_id")]
        public long AccountId { get; set; }

        /// <summary>
        /// Gets or sets player's steam identifier.
        /// </summary>
        [JsonPropertyName("steamid")]
        public string SteamId { get; set; }

        /// <summary>
        /// Gets or sets steam picture URL (small picture).
        /// </summary>
        [JsonPropertyName("avatar")]
        public Uri Avatar { get; set; }

        /// <summary>
        /// Gets or sets steam picture URL (medium picture).
        /// </summary>
        [JsonPropertyName("avatarmedium")]
        public Uri AvatarMedium { get; set; }

        /// <summary>
        /// Gets or sets steam picture URL (full picture).
        /// </summary>
        [JsonPropertyName("avatarfull")]
        public Uri AvatarFull { get; set; }

        /// <summary>
        /// Gets or sets steam profile URL.
        /// </summary>
        [JsonPropertyName("profileurl")]
        public Uri ProfileUrl { get; set; }

        /// <summary>
        /// Gets or sets player's Steam name.
        /// </summary>
        [JsonPropertyName("personaname")]
        public string PersonaName { get; set; }

        /// <summary>
        /// Gets or sets date and time of last login to OpenDota.
        /// </summary>
        [JsonPropertyName("last_login")]
        public DateTimeOffset? LastLogin { get; set; }

        /// <summary>
        /// Gets or sets date and time of last request to refresh player's match history.
        /// </summary>
        [JsonPropertyName("full_history_time")]
        public DateTimeOffset? FullHistoryTime { get; set; }

        /// <summary>
        /// Gets or sets amount of dollars the player has donated to OpenDota.
        /// </summary>
        [JsonPropertyName("cheese")]
        public int Cheese { get; set; }

        /// <summary>
        /// Gets or sets whether the refresh of player' match history failed.
        /// </summary>
        [JsonPropertyName("fh_unavailable")]
        public bool? FhUnavailable { get; set; }

        /// <summary>
        /// Gets or sets player's country identifier, e.g. US.
        /// </summary>
        [JsonPropertyName("loccountrycode")]
        public string LocCountryCode { get; set; }

        /// <summary>
        /// Gets or sets last match time.
        /// </summary>
        [JsonPropertyName("last_match_time")]
        public DateTimeOffset LastMatchTime { get; set; }

        /// <summary>
        /// Gets or sets plus.
        /// </summary>
        [JsonPropertyName("plus")]
        public bool? Plus { get; set; }

        /// <summary>
        /// Gets or sets verified player name, e.g. 'Miracle-'.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets player's country code.
        /// </summary>
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets player's ingame role (core: 1 or support: 2).
        /// </summary>
        [JsonPropertyName("fantasy_role")]
        public int FantasyRole { get; set; }

        /// <summary>
        /// Gets or sets player's team identifier.
        /// </summary>
        [JsonPropertyName("team_id")]
        public long TeamId { get; set; }

        /// <summary>
        /// Gets or sets player's team name, e.g. 'Evil Geniuses'.
        /// </summary>
        [JsonPropertyName("team_name")]
        public string TeamName { get; set; }

        /// <summary>
        /// Gets or sets player's team shorthand tag, e.g. 'EG'.
        /// </summary>
        [JsonPropertyName("team_tag")]
        public string TeamTag { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the roster lock is active.
        /// </summary>
        [JsonPropertyName("is_locked")]
        public bool IsLocked { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the player is professional or not.
        /// </summary>
        [JsonPropertyName("is_pro")]
        public bool IsPro { get; set; }

        // NOTE: This properly always returns null
        ///// <summary>
        ///// When the roster lock will end
        ///// </summary>
        // [JsonPropertyName("locked_until")]
        // public object LockedUntil { get; set; }
    }
}
