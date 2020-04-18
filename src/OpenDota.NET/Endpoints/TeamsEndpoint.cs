namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Teams;

    public class TeamsEndpoint : ITeamsEndpoint
    {
        private readonly Requester requester;

        public TeamsEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <inheritdoc />
        public async Task<List<Team>> GetTeamsAsync() =>
            await this.requester.GetResponseAsync<List<Team>>("teams");

        /// <inheritdoc />
        public async Task<Team> GetTeamByIdAsync(int teamId) =>
            await this.requester.GetResponseAsync<Team>($"teams/{teamId}");

        /// <inheritdoc />
        public async Task<List<TeamMatch>> GetTeamMatchesByIdAsync(int teamId) =>
            await this.requester.GetResponseAsync<List<TeamMatch>>($"teams/{teamId}/matches");

        /// <inheritdoc />
        public async Task<List<TeamPlayer>> GetTeamPlayersByIdAsync(int teamId) =>
            await this.requester.GetResponseAsync<List<TeamPlayer>>($"teams/{teamId}/players");

        /// <inheritdoc />
        public async Task<List<TeamHero>> GetTeamHeroesByIdAsync(int teamId) =>
            await this.requester.GetResponseAsync<List<TeamHero>>($"teams/{teamId}/heroes");
    }
}
