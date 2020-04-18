namespace OpenDotaDotNet.Models.Metadata
{
    using System.Text.Json.Serialization;

    public class Metadata
    {
        [JsonPropertyName("scenarios")]
        public Scenarios Scenarios { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; }

        [JsonPropertyName("banner")]
        public object Banner { get; set; }

        [JsonPropertyName("cheese")]
        public Cheese Cheese { get; set; }
    }
}
