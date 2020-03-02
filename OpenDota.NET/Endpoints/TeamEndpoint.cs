using Newtonsoft.Json;

using OpenDotaDotNet.Models.Teams;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Endpoints
{
    public class TeamEndpoint : ITeamEndpoint
    {
        private const string GetTeams = "teams";
        private const string GetTeamById = "teams/{0}";
        private const string GetTeamMatchesById = "teams/{0}/matches";
        private const string GetTeamPlayersById = "teams/{0}/players";
        private const string GetTeamHeroesById = "teams/{0}/heroes";

        private readonly Requester requester;

        public TeamEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Get team data
        /// </summary>
        /// <returns></returns>
        public async Task<List<Team>> GetTeamsAsync()
        {
            var response = await this.requester.GetRequestResponseMessageAsync(GetTeams);

            response.EnsureSuccessStatusCode();

            var teams = JsonConvert.DeserializeObject<List<Team>>(await response.Content.ReadAsStringAsync());

            return teams;
        }

        /// <summary>
        /// Get data for a team
        /// </summary>
        /// <param name="teamId"></param>
        /// <returns></returns>
        public async Task<Team> GetTeamByIdAsync(int teamId)
        {
            var response = await this.requester.GetRequestResponseMessageAsync(string.Format(GetTeamById, teamId));

            response.EnsureSuccessStatusCode();

            var team = JsonConvert.DeserializeObject<Team>(await response.Content.ReadAsStringAsync());

            return team;
        }

        /// <summary>
        /// Get matches for a team
        /// </summary>
        /// <param name="teamId"></param>
        /// <returns></returns>
        public async Task<List<TeamMatch>> GetTeamMatchesByIdAsync(int teamId)
        {
            var response = await this.requester.GetRequestResponseMessageAsync(string.Format(GetTeamMatchesById, teamId));

            response.EnsureSuccessStatusCode();

            var teamMatches = JsonConvert.DeserializeObject<List<TeamMatch>>(await response.Content.ReadAsStringAsync());

            return teamMatches;
        }

        /// <summary>
        /// Get players who have played for a team
        /// </summary>
        /// <param name="teamId"></param>
        /// <returns></returns>
        public async Task<List<TeamPlayer>> GetTeamPlayersByIdAsync(int teamId)
        {
            var response = await this.requester.GetRequestResponseMessageAsync(string.Format(GetTeamPlayersById, teamId));

            response.EnsureSuccessStatusCode();

            var teamPlayers = JsonConvert.DeserializeObject<List<TeamPlayer>>(await response.Content.ReadAsStringAsync());

            return teamPlayers;
        }

        /// <summary>
        /// Get heroes for a team
        /// </summary>
        /// <param name="teamId"></param>
        /// <returns></returns>
        public async Task<List<TeamHero>> GetTeamHeroesByIdAsync(int teamId)
        {
            var response = await this.requester.GetRequestResponseMessageAsync(string.Format(GetTeamHeroesById, teamId));

            response.EnsureSuccessStatusCode();

            var teamHeroes = JsonConvert.DeserializeObject<List<TeamHero>>(await response.Content.ReadAsStringAsync());

            return teamHeroes;
        }
    }
}
