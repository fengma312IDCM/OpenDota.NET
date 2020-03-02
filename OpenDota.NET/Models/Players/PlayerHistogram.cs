namespace OpenDotaDotNet.Models.Players
{
    using Newtonsoft.Json;

    public class PlayerHistogram
    {
        /// <summary>
        /// Gets or sets the X factor of the histogram.
        /// </summary>
        [JsonProperty("x")]
        public long? X { get; set; }

        [JsonProperty("games")]
        public int Games { get; set; }

        [JsonProperty("win")]
        public int Win { get; set; }
    }
}
