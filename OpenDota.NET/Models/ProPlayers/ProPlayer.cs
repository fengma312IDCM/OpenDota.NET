namespace OpenDotaDotNet.Models.ProPlayers
{
    using System;

    using Newtonsoft.Json;

    public class ProPlayer
    {
        /// <summary>
        /// Gets or sets player's account identifier.
        /// </summary>
        [JsonProperty("account_id")]
        public long AccountId { get; set; }

        /// <summary>
        /// Gets or sets player's steam identifier.
        /// </summary>
        [JsonProperty("steamid")]
        public string SteamId { get; set; }

        /// <summary>
        /// Gets or sets steam picture URL (small picture).
        /// </summary>
        [JsonProperty("avatar")]
        public Uri Avatar { get; set; }

        /// <summary>
        /// Gets or sets steam picture URL (medium picture).
        /// </summary>
        [JsonProperty("avatarmedium")]
        public Uri AvatarMedium { get; set; }

        /// <summary>
        /// Gets or sets steam picture URL (full picture).
        /// </summary>
        [JsonProperty("avatarfull")]
        public Uri AvatarFull { get; set; }

        /// <summary>
        /// Gets or sets steam profile URL.
        /// </summary>
        [JsonProperty("profileurl")]
        public Uri ProfileUrl { get; set; }

        /// <summary>
        /// Gets or sets player's Steam name.
        /// </summary>
        [JsonProperty("personaname")]
        public string PersonaName { get; set; }

        /// <summary>
        /// Gets or sets date and time of last login to OpenDota.
        /// </summary>
        [JsonProperty("last_login")]
        public DateTimeOffset? LastLogin { get; set; }

        /// <summary>
        /// Gets or sets date and time of last request to refresh player's match history.
        /// </summary>
        [JsonProperty("full_history_time")]
        public DateTimeOffset? FullHistoryTime { get; set; }

        /// <summary>
        /// Gets or sets amount of dollars the player has donated to OpenDota.
        /// </summary>
        [JsonProperty("cheese")]
        public int Cheese { get; set; }

        /// <summary>
        /// Gets or sets whether the refresh of player' match history failed.
        /// </summary>
        [JsonProperty("fh_unavailable")]
        public bool? FhUnavailable { get; set; }

        /// <summary>
        /// Gets or sets player's country identifier, e.g. US.
        /// </summary>
        [JsonProperty("loccountrycode")]
        public string LocCountryCode { get; set; }

        /// <summary>
        /// Gets or sets last match time.
        /// </summary>
        [JsonProperty("last_match_time")]
        public DateTimeOffset LastMatchTime { get; set; }

        /// <summary>
        /// Gets or sets plus.
        /// </summary>
        [JsonProperty("plus")]
        public bool? Plus { get; set; }

        /// <summary>
        /// Gets or sets verified player name, e.g. 'Miracle-'.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets player's country code.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets player's ingame role (core: 1 or support: 2).
        /// </summary>
        [JsonProperty("fantasy_role")]
        public int FantasyRole { get; set; }

        /// <summary>
        /// Gets or sets player's team identifier.
        /// </summary>
        [JsonProperty("team_id")]
        public long TeamId { get; set; }

        /// <summary>
        /// Gets or sets player's team name, e.g. 'Evil Geniuses'.
        /// </summary>
        [JsonProperty("team_name")]
        public string TeamName { get; set; }

        /// <summary>
        /// Gets or sets player's team shorthand tag, e.g. 'EG'.
        /// </summary>
        [JsonProperty("team_tag")]
        public string TeamTag { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the roster lock is active.
        /// </summary>
        [JsonProperty("is_locked")]
        public bool IsLocked { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the player is professional or not.
        /// </summary>
        [JsonProperty("is_pro")]
        public bool IsPro { get; set; }

        // NOTE: This properly always returns null
        ///// <summary>
        ///// When the roster lock will end
        ///// </summary>
        // [JsonProperty("locked_until")]
        // public object LockedUntil { get; set; }
    }
}
