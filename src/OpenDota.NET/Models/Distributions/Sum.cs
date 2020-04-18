namespace OpenDotaDotNet.Models.Distributions
{
    using System.Text.Json.Serialization;

    public class Sum
    {
        [JsonPropertyName("count")]
        public long Count { get; set; }
    }
}
