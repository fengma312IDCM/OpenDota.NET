namespace OpenDotaDotNet.Models.Players
{
    using Newtonsoft.Json;

    public class MmrEstimate
    {
        [JsonProperty("estimate")]
        public int? Estimate { get; set; }
    }
}
