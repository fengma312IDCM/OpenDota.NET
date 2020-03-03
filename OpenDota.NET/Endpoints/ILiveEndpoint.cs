namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Live;

    public interface ILiveEndpoint
    {
        /// <summary>
        /// Get top currently ongoing live games.
        /// </summary>
        /// <returns>Top currently ongoing live games.</returns>
        Task<List<LiveGame>> GetTopLiveGamesAsync();
    }
}
