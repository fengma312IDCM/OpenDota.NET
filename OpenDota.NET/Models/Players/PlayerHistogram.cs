namespace OpenDotaDotNet.Models.Players
{
    using System.Text.Json.Serialization;

    public class PlayerHistogram
    {
        /// <summary>
        /// Gets or sets the X factor of the histogram.
        /// </summary>
        [JsonPropertyName("x")]
        public long? X { get; set; }

        [JsonPropertyName("games")]
        public int Games { get; set; }

        [JsonPropertyName("win")]
        public int Win { get; set; }
    }
}
