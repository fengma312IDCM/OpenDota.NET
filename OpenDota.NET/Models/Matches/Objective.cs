namespace OpenDotaDotNet.Models.Matches
{
    using Newtonsoft.Json;

    public class Objective
    {
        // Time (in seconds) when the objective happened
        [JsonProperty("time")]
        public long Time { get; set; }

        // Type of objective (courier kill, tower kill, first blood, etc)
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("slot", NullValueHandling = NullValueHandling.Ignore)]
        public long? Slot { get; set; }

        // Returns integers and strings [need a full list]
        [JsonProperty("key")]
        public Key? Key { get; set; }

        // Slot of player who got the objective
        [JsonProperty("player_slot", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlayerSlot { get; set; }

        // Which unit got the objective
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }

        // Which team got the objective
        [JsonProperty("team", NullValueHandling = NullValueHandling.Ignore)]
        public long? Team { get; set; }
    }
}
