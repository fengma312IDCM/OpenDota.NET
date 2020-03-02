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
        /// <returns></returns>
        Task<List<LiveGame>> GetTopLiveGamesAsync();
    }
}
