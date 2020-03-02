namespace OpenDotaDotNet.Models.Players
{
    using Newtonsoft.Json;

    public class PlayerCountStats
    {
        [JsonProperty("games")]
        public long Games { get; set; }

        [JsonProperty("win")]
        public long Win { get; set; }
    }
}
