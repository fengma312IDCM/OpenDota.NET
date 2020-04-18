namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.FindMatches;

    public interface IFindMatchesEndpoint
    {
        /// <summary>
        /// Finds matches by heroes played (currently includes matches played after April 2019).
        /// </summary>
        /// <param name="teamA"></param>
        /// <param name="teamB"></param>
        /// <returns>Matches by heroes played.</returns>
        Task<IEnumerable<FindMatch>> FindMatchesByHeroesPlayedAsync(
            IEnumerable<int> teamA = null,
            IEnumerable<int> teamB = null);
    }
}
