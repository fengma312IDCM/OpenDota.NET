namespace OpenDotaDotNet.Models.Players
{
    using System;
    using System.Text.Json.Serialization;

    public class PlayerPro
    {
        [JsonPropertyName("account_id")]
        public long AccountId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        [JsonPropertyName("fantasy_role")]
        public long FantasyRole { get; set; }

        [JsonPropertyName("team_id")]
        public long TeamId { get; set; }

        [JsonPropertyName("team_name")]
        public string TeamName { get; set; }

        [JsonPropertyName("team_tag")]
        public string TeamTag { get; set; }

        [JsonPropertyName("is_locked")]
        public bool IsLocked { get; set; }

        [JsonPropertyName("is_pro")]
        public bool IsPro { get; set; }

        [JsonPropertyName("locked_until")]
        public object LockedUntil { get; set; }

        [JsonPropertyName("steamid")]
        public string Steamid { get; set; }

        [JsonPropertyName("avatar")]
        public Uri Avatar { get; set; }

        [JsonPropertyName("avatarmedium")]
        public Uri Avatarmedium { get; set; }

        [JsonPropertyName("avatarfull")]
        public Uri Avatarfull { get; set; }

        [JsonPropertyName("profileurl")]
        public Uri Profileurl { get; set; }

        [JsonPropertyName("personaname")]
        public string Personaname { get; set; }

        [JsonPropertyName("last_login")]
        public DateTimeOffset? LastLogin { get; set; }

        [JsonPropertyName("full_history_time")]
        public DateTimeOffset? FullHistoryTime { get; set; }

        [JsonPropertyName("cheese")]
        public long Cheese { get; set; }

        [JsonPropertyName("fh_unavailable")]
        public bool? FhUnavailable { get; set; }

        [JsonPropertyName("loccountrycode")]
        public string Loccountrycode { get; set; }

        [JsonPropertyName("last_match_time")]
        public DateTimeOffset LastMatchTime { get; set; }

        [JsonPropertyName("plus")]
        public bool? Plus { get; set; }

        [JsonPropertyName("last_played")]
        public long LastPlayed { get; set; }

        [JsonPropertyName("win")]
        public long Win { get; set; }

        [JsonPropertyName("games")]
        public long Games { get; set; }

        [JsonPropertyName("with_win")]
        public long WithWin { get; set; }

        [JsonPropertyName("with_games")]
        public long WithGames { get; set; }

        [JsonPropertyName("against_win")]
        public long AgainstWin { get; set; }

        [JsonPropertyName("against_games")]
        public long AgainstGames { get; set; }

        [JsonPropertyName("with_gpm_sum")]
        public long? WithGpmSum { get; set; }

        [JsonPropertyName("with_xpm_sum")]
        public long? WithXpmSum { get; set; }
    }
}
