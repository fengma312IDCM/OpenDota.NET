namespace OpenDotaDotNet.Models.Matches
{
    using Newtonsoft.Json;

    public class RuneLog
    {
        // Key of the picked up rune
        [JsonProperty("key")]
        public long Key { get; set; }

        // Time in seconds when the rune was picked up
        [JsonProperty("time")]
        public long Time { get; set; }
    }
}
