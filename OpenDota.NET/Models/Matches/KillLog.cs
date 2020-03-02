namespace OpenDotaDotNet.Models.Matches
{
    using Newtonsoft.Json;

    public class KillLog
    {
        // The unit who got killed
        [JsonProperty("key")]
        public string Key { get; set; }

        // Time in seconds when the kill happened
        [JsonProperty("time")]
        public long Time { get; set; }
    }
}
