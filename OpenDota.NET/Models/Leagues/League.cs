namespace OpenDotaDotNet.Models.Leagues
{
    using System.Text.Json.Serialization;

    public class League
    {
        [JsonPropertyName("leagueid")]
        public long Leagueid { get; set; }

        [JsonPropertyName("ticket")]
        public string Ticket { get; set; }

        [JsonPropertyName("banner")]
        public string Banner { get; set; }

        [JsonPropertyName("tier")]
        public LeagueTier? Tier { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
