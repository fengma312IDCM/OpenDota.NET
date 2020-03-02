namespace OpenDotaDotNet.Models.Scenarios
{
    using Newtonsoft.Json;

    public class MiscellaneousTeamScenario
    {
        /// <summary>
        /// Gets or sets the scenario's name or description.
        /// </summary>
        [JsonProperty("scenario")]
        public string Scenario { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Radiant executed this scenario.
        /// </summary>
        [JsonProperty("is_radiant")]
        public bool IsRadiant { get; set; }

        /// <summary>
        /// Gets or sets region the game was played in.
        /// </summary>
        [JsonProperty("region")]
        public int Region { get; set; }

        /// <summary>
        /// Gets or sets the number of games where this scenario occurred.
        /// </summary>
        [JsonProperty("games")]
        public int Games { get; set; }

        /// <summary>
        /// Gets or sets the number of games won where this scenario occured.
        /// </summary>
        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}
