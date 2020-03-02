namespace OpenDotaDotNet.Models.Metadata
{
    using Newtonsoft.Json;

    public class Metadata
    {
        [JsonProperty("banner")]
        public object Banner { get; set; }

        [JsonProperty("cheese")]
        public Cheese Cheese { get; set; }
    }
}
