namespace OpenDotaDotNet.Models.Teams
{
    using System.Text.Json.Serialization;

    public class TeamPlayer
    {
        [JsonPropertyName("account_id")]
        public long AccountId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("games_played")]
        public long GamesPlayed { get; set; }

        [JsonPropertyName("wins")]
        public long Wins { get; set; }

        [JsonPropertyName("is_current_team_member")]
        public bool? IsCurrentTeamMember { get; set; }
    }
}
