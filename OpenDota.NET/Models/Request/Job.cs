namespace OpenDotaDotNet.Models.Request
{
    using Newtonsoft.Json;

    public class Job
    {
        [JsonProperty("jobId")]
        public long JobId { get; set; }
    }
}
