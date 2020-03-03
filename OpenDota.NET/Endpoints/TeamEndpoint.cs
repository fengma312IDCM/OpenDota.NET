namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Teams;

    public class TeamEndpoint : ITeamEndpoint
    {
        private readonly Requester requester;

        public TeamEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Get teams data.
        /// </summary>
        /// <returns>Teams data.</returns>
        public async Task<List<Team>> GetTeamsAsync() =>
            await this.requester.GetResponseAsync<List<Team>>("teams");

        /// <summary>
        /// Get data for a team.
        /// </summary>
        /// <param name="teamId"></param>
        /// <returns>Data for a team.</returns>
        public async Task<Team> GetTeamByIdAsync(int teamId) =>
            await this.requester.GetResponseAsync<Team>($"teams/{teamId}");

        /// <summary>
        /// Get matches for a team.
        /// </summary>
        /// <param name="teamId"></param>
        /// <returns>Matches for a team.</returns>
        public async Task<List<TeamMatch>> GetTeamMatchesByIdAsync(int teamId) =>
            await this.requester.GetResponseAsync<List<TeamMatch>>($"teams/{teamId}/matches");

        /// <summary>
        /// Get players who have played for a team.
        /// </summary>
        /// <param name="teamId"></param>
        /// <returns>Players who have played for a team.</returns>
        public async Task<List<TeamPlayer>> GetTeamPlayersByIdAsync(int teamId) =>
            await this.requester.GetResponseAsync<List<TeamPlayer>>($"teams/{teamId}/players");

        /// <summary>
        /// Get heroes for a team.
        /// </summary>
        /// <param name="teamId"></param>
        /// <returns>Heroes for a team.</returns>
        public async Task<List<TeamHero>> GetTeamHeroesByIdAsync(int teamId) =>
            await this.requester.GetResponseAsync<List<TeamHero>>($"teams/{teamId}/heroes");
    }
}
