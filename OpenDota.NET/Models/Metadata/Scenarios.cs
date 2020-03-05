namespace OpenDotaDotNet.Models.Metadata
{
    using System.Text.Json.Serialization;

    public class Scenarios
    {
        [JsonPropertyName("itemCost")]
        public int ItemCost { get; set; }

        [JsonPropertyName("timings")]
        public int[] Timings { get; set; }

        [JsonPropertyName("gameDurationBucket")]
        public int[] GameDurationBucket { get; set; }

        [JsonPropertyName("teamScenariosQueryParams")]
        public string[] TeamScenariosQueryParams { get; set; }
    }
}
