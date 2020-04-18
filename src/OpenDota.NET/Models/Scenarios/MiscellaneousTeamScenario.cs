namespace OpenDotaDotNet.Models.Scenarios
{
    using System.Text.Json.Serialization;

    public class MiscellaneousTeamScenario
    {
        /// <summary>
        /// Gets or sets the scenario's name or description.
        /// </summary>
        [JsonPropertyName("scenario")]
        public string Scenario { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Radiant executed this scenario.
        /// </summary>
        [JsonPropertyName("is_radiant")]
        public bool IsRadiant { get; set; }

        /// <summary>
        /// Gets or sets region the game was played in.
        /// </summary>
        [JsonPropertyName("region")]
        public int Region { get; set; }

        /// <summary>
        /// Gets or sets the number of games where this scenario occurred.
        /// </summary>
        [JsonPropertyName("games")]
        public int Games { get; set; }

        /// <summary>
        /// Gets or sets the number of games won where this scenario occured.
        /// </summary>
        [JsonPropertyName("wins")]
        public int Wins { get; set; }
    }
}
