namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Search;

    public interface ISearchEndpoint
    {
        /// <summary>
        /// Search players by personaname.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        Task<List<SearchPlayerResponse>> GetPlayersByNameAsync(string query);
    }
}
