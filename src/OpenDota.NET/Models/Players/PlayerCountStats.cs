namespace OpenDotaDotNet.Models.Players
{
    using System.Text.Json.Serialization;

    public class PlayerCountStats
    {
        [JsonPropertyName("games")]
        public long Games { get; set; }

        [JsonPropertyName("win")]
        public long Win { get; set; }
    }
}
