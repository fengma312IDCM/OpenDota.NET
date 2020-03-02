namespace OpenDotaDotNet.Models.Records
{
    using Newtonsoft.Json;

    public class Record
    {
        [JsonProperty("match_id")]
        public string MatchId { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or sets the ID value of the hero played.
        /// </summary>
        [JsonProperty("hero_id")]
        public int HeroId { get; set; }

        [JsonProperty("score")]
        public long Score { get; set; }
    }
}
