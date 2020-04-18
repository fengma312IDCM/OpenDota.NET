namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.ProPlayers;

    public interface IProPlayerEndpoint
    {
        /// <summary>
        /// Get list of pro players.
        /// </summary>
        /// <returns>List of pro players.</returns>
        Task<List<ProPlayer>> GetProPlayersAsync();
    }
}
