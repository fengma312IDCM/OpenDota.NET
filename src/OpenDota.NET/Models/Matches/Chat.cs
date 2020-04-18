namespace OpenDotaDotNet.Models.Matches
{
    using System.Text.Json.Serialization;

    public class Chat
    {
        // Time in seconds at which the message was said
        [JsonPropertyName("time")]
        public int Time { get; set; }

        // Type of message [currently known values - "chat" and "chatwheel"]
        [JsonPropertyName("type")]
        public string Type { get; set; }

        // The message the player sent
        [JsonPropertyName("key")]
        public string Key { get; set; }

        // The slot of the player
        [JsonPropertyName("slot")]
        public long Slot { get; set; }

        // Which slot the player is in. 0-127 are Radiant, 128-255 are Dire
        [JsonPropertyName("player_slot")]
        public long PlayerSlot { get; set; }

        // Name of the player who sent the message
        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }
}
