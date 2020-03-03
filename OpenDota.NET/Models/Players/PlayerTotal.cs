namespace OpenDotaDotNet.Models.Players
{
    using System.Text.Json.Serialization;

    public class PlayerTotal
    {
        [JsonPropertyName("field")]
        public string Field { get; set; }

        [JsonPropertyName("n")]
        public long Number { get; set; }

        [JsonPropertyName("sum")]
        public double Sum { get; set; }
    }
}
