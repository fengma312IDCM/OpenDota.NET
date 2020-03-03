namespace OpenDotaDotNet.Models.Search
{
    using System;
    using System.Text.Json.Serialization;

    public class SearchPlayerResponse
    {
        [JsonPropertyName("account_id")]
        public long AccountId { get; set; }

        [JsonPropertyName("personaname")]
        public string PersonaName { get; set; }

        [JsonPropertyName("avatarfull")]
        public Uri AvatarFull { get; set; }

        /// <summary>
        /// Gets or sets last_match_time. May not be present or null.
        /// </summary>
        [JsonPropertyName("last_match_time")]
        public DateTimeOffset? LastMatchTime { get; set; }

        [JsonPropertyName("similarity")]
        public double Similarity { get; set; }
    }
}
