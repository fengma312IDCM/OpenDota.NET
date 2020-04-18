namespace OpenDotaDotNet.Models.Request
{
    using System.Text.Json.Serialization;

    public class Job
    {
        [JsonPropertyName("jobId")]
        public long JobId { get; set; }
    }
}
