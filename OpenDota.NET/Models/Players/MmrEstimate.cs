namespace OpenDotaDotNet.Models.Players
{
    using System.Text.Json.Serialization;

    public class MmrEstimate
    {
        [JsonPropertyName("estimate")]
        public int? Estimate { get; set; }
    }
}
