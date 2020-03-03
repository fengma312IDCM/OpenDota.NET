namespace OpenDotaDotNet.Models.Distributions
{
    using System.Text.Json.Serialization;

    public class MmrRow
    {
        [JsonPropertyName("bin")]
        public int Bin { get; set; }

        [JsonPropertyName("bin_name")]
        public int BinName { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("cumulative_sum")]
        public long CumulativeSum { get; set; }
    }
}
