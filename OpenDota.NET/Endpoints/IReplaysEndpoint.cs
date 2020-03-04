namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Replays;

    public interface IReplaysEndpoint
    {
        /// <summary>
        /// Get data to construct a replay URL with.
        /// </summary>
        /// <param name="matchIds">Match IDs (array).</param>
        /// <returns>Data to construct a replay URL with.</returns>
        Task<List<Replay>> GetReplayDataAsync(List<long> matchIds);
    }
}
