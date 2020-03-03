namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.FindMatches;

    public interface IFindMatchEndpoint
    {
        /// <summary>
        /// Finds matches by heroes played (currently includes matches played after April 2019).
        /// </summary>
        /// <param name="teamA"></param>
        /// <param name="teamB"></param>
        /// <returns>Matches by heroes played.</returns>
        Task<List<FindMatch>> FindMatchesByHeroesPlayedAsync(List<int> teamA = null, List<int> teamB = null);
    }
}
