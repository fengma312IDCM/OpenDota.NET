namespace OpenDotaDotNet.Models.Players
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class PlayerWardmap
    {
        [JsonProperty("obs")]
        public Dictionary<string, Dictionary<string, long>> Obs { get; set; }

        [JsonProperty("sen")]
        public Dictionary<string, Dictionary<string, long>> Sen { get; set; }
    }
}
