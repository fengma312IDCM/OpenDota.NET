namespace OpenDotaDotNet.Models.Teams
{
    using Newtonsoft.Json;

    public class TeamHero
    {
        [JsonProperty("hero_id")]
        public int HeroId { get; set; }

        [JsonProperty("localized_name")]
        public string LocalizedName { get; set; }

        [JsonProperty("games_played")]
        public int GamesPlayed { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}
