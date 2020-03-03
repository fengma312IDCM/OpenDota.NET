namespace OpenDotaDotNet.Models.Metadata
{
    using System.Text.Json.Serialization;

    public class Metadata
    {
        [JsonPropertyName("banner")]
        public object Banner { get; set; }

        [JsonPropertyName("cheese")]
        public Cheese Cheese { get; set; }
    }
}
