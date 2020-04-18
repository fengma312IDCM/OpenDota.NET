namespace OpenDotaDotNet.Endpoints
{
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Matches;

    public interface IMatchesEndpoint
    {
        /// <summary>
        /// Get match data by ID.
        /// </summary>
        /// <param name="matchId">Id of the match.</param>
        /// <returns>Match data.</returns>
        Task<Match> GetMatchByIdAsync(long matchId);
    }
}
