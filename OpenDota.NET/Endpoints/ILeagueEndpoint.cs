namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Leagues;

    public interface ILeagueEndpoint
    {
        /// <summary>
        /// Get league data.
        /// </summary>
        /// <returns>League data.</returns>
        Task<List<League>> GetLeaguesAsync();
    }
}
