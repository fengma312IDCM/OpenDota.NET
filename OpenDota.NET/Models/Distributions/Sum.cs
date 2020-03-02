namespace OpenDotaDotNet.Models.Distributions
{
    using Newtonsoft.Json;

    public class Sum
    {
        [JsonProperty("count")]
        public long Count { get; set; }
    }
}
