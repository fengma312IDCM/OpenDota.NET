namespace OpenDotaDotNet.Models.Metadata
{
    using Newtonsoft.Json;

    public class Cheese
    {
        [JsonProperty("cheese")]
        public int CheeseAmount { get; set; }

        [JsonProperty("goal")]
        public int Goal { get; set; }
    }
}
