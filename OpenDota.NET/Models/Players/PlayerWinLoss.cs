namespace OpenDotaDotNet.Models.Players
{
    using Newtonsoft.Json;

    public class PlayerWinLoss
    {
        [JsonProperty("win")]
        public int Wins { get; set; }

        [JsonProperty("lose")]
        public int Losses { get; set; }
    }
}
