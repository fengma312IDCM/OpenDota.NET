namespace OpenDotaDotNet.Models.Request
{
    using System.Text.Json.Serialization;

    public class ParseRequest
    {
        [JsonPropertyName("job")]
        public Job Job { get; set; }
    }
}
