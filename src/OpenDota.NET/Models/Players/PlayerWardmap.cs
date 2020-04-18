namespace OpenDotaDotNet.Models.Players
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PlayerWardmap
    {
        [JsonPropertyName("obs")]
        public Dictionary<string, Dictionary<string, long>> Obs { get; set; }

        [JsonPropertyName("sen")]
        public Dictionary<string, Dictionary<string, long>> Sen { get; set; }
    }
}
