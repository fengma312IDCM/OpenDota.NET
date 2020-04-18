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
        /// <param name="query">Search string.</param>
        /// <returns>Players by personaname.</returns>
        Task<IEnumerable<SearchPlayerResponse>> GetPlayersByNameAsync(string query);
    }
}
