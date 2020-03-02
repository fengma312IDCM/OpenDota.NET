namespace OpenDotaDotNet.Models.Players
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class PlayerWordcloud
    {
        [JsonProperty("my_word_counts")]
        public Dictionary<string, long> MyWordCounts { get; set; }

        [JsonProperty("all_word_counts")]
        public Dictionary<string, long> AllWordCounts { get; set; }
    }
}
