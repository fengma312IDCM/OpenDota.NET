namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Teams;

    public interface ITeamsEndpoint
    {
        /// <summary>
        /// Get team data.
        /// </summary>
        /// <returns>Team data.</returns>
        Task<IEnumerable<Team>> GetTeamsAsync();

        /// <summary>
        /// Get data for a team.
        /// </summary>
        /// <param name="teamId"></param>
        /// <returns>Data for a team.</returns>
        Task<Team> GetTeamByIdAsync(int teamId);

        /// <summary>
        /// Get matches for a team.
        /// </summary>
        /// <param name="teamId"></param>
        /// <returns>Matches for a team.</returns>
        Task<IEnumerable<TeamMatch>> GetTeamMatchesByIdAsync(int teamId);

        /// <summary>
        /// Get players who have played for a team.
        /// </summary>
        /// <param name="teamId"></param>
        /// <returns>Players who have played for a team.</returns>
        Task<IEnumerable<TeamPlayer>> GetTeamPlayersByIdAsync(int teamId);

        /// <summary>
        /// Get heroes for a team.
        /// </summary>
        /// <param name="teamId"></param>
        /// <returns>Heroes for a team.</returns>
        Task<IEnumerable<TeamHero>> GetTeamHeroesByIdAsync(int teamId);
    }
}
