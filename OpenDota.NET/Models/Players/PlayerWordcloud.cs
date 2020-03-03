namespace OpenDotaDotNet.Models.Players
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PlayerWordcloud
    {
        [JsonPropertyName("my_word_counts")]
        public Dictionary<string, long> MyWordCounts { get; set; }

        [JsonPropertyName("all_word_counts")]
        public Dictionary<string, long> AllWordCounts { get; set; }
    }
}
