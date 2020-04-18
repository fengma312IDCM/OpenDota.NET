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
        public async Task<IEnumerable<Team>> GetTeamsAsync() =>
            await this.requester.GetResponseAsync<IEnumerable<Team>>("teams");

        /// <inheritdoc />
        public async Task<Team> GetTeamByIdAsync(int teamId) =>
            await this.requester.GetResponseAsync<Team>($"teams/{teamId}");

        /// <inheritdoc />
        public async Task<IEnumerable<TeamMatch>> GetTeamMatchesByIdAsync(int teamId) =>
            await this.requester.GetResponseAsync<IEnumerable<TeamMatch>>($"teams/{teamId}/matches");

        /// <inheritdoc />
        public async Task<IEnumerable<TeamPlayer>> GetTeamPlayersByIdAsync(int teamId) =>
            await this.requester.GetResponseAsync<IEnumerable<TeamPlayer>>($"teams/{teamId}/players");

        /// <inheritdoc />
        public async Task<IEnumerable<TeamHero>> GetTeamHeroesByIdAsync(int teamId) =>
            await this.requester.GetResponseAsync<IEnumerable<TeamHero>>($"teams/{teamId}/heroes");
    }
}
