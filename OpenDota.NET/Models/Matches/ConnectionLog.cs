namespace OpenDotaDotNet.Models.Matches
{
    using System.Text.Json.Serialization;

    public class ConnectionLog
    {
        // Event that occurred (connect, reconnect, disconnect)
        [JsonPropertyName("event")]
        public string Event { get; set; }

        // Which slot the player is in. 0-127 are Radiant, 128-255 are Dire
        [JsonPropertyName("player_slot")]
        public long PlayerSlot { get; set; }

        [JsonPropertyName("slot")]
        public long Slot { get; set; }

        // Game time in seconds the event ocurred
        [JsonPropertyName("time")]
        public long Time { get; set; }

        // Type of log (should always be "connection_log")
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
