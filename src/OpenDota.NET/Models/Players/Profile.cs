namespace OpenDotaDotNet.Models.Players
{
    using System;
    using System.Text.Json.Serialization;

    public class Profile
    {
        [JsonPropertyName("account_id")]
        public long AccountId { get; set; }

        [JsonPropertyName("personaname")]
        public string Personaname { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("plus")]
        public bool? Plus { get; set; }

        [JsonPropertyName("cheese")]
        public long Cheese { get; set; }

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

        [JsonPropertyName("last_login")]
        public DateTimeOffset? LastLogin { get; set; }

        [JsonPropertyName("loccountrycode")]
        public string Loccountrycode { get; set; }

        [JsonPropertyName("is_contributor")]
        public bool IsContributor { get; set; }
    }
}
