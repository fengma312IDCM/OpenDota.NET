namespace OpenDotaDotNet.Endpoints
{
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Matches;

    public interface IMatchEndpoint
    {
        /// <summary>
        /// Get match data by ID.
        /// </summary>
        /// <param name="matchId">Id of the match.</param>
        /// <returns></returns>
        Task<Match> GetMatchByIdAsync(long matchId);
    }
}
