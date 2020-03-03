namespace OpenDotaDotNet.Models.Players
{
    using System.Text.Json.Serialization;

    public class PlayerWinLoss
    {
        [JsonPropertyName("win")]
        public int Wins { get; set; }

        [JsonPropertyName("lose")]
        public int Losses { get; set; }
    }
}
