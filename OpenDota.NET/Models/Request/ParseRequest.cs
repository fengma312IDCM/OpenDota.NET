namespace OpenDotaDotNet.Models.Request
{
    using Newtonsoft.Json;

    public class ParseRequest
    {
        [JsonProperty("job")]
        public Job Job { get; set; }
    }
}
