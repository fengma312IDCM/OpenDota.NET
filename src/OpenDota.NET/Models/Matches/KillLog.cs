namespace OpenDotaDotNet.Models.Matches
{
    using System.Text.Json.Serialization;

    public class KillLog
    {
        // The unit who got killed
        [JsonPropertyName("key")]
        public string Key { get; set; }

        // Time in seconds when the kill happened
        [JsonPropertyName("time")]
        public long Time { get; set; }
    }
}
