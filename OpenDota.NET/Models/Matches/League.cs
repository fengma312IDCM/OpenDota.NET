namespace OpenDotaDotNet.Models.Matches
{
    using System.Text.Json.Serialization;

    public class League
    {
        // Id of league
        [JsonPropertyName("leagueid")]
        public long Leagueid { get; set; }

        // always null?
        // [JsonPropertyName("ticket")]
        // public object Ticket { get; set; }

        // Banner of the league - always returns null?
        // [JsonPropertyName("banner")]
        // public object Banner { get; set; }

        // League tier (amateur, professional, etc)
        [JsonPropertyName("tier")]
        public string Tier { get; set; }

        // Name of the league
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
