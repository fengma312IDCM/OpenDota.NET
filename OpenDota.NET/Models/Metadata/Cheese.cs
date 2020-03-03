namespace OpenDotaDotNet.Models.Metadata
{
    using System.Text.Json.Serialization;

    public class Cheese
    {
        [JsonPropertyName("cheese")]
        public int CheeseAmount { get; set; }

        [JsonPropertyName("goal")]
        public int Goal { get; set; }
    }
}
