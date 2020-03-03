namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.ProMatches;

    public interface IFeedEndpoint
    {
        /// <summary>
        /// Get streaming feed of latest matches.
        /// This endpoint requires API key.
        /// </summary>
        /// <param name="sequenceNumber"></param>
        /// <param name="gameMode"></param>
        /// <param name="leagueId"></param>
        /// <param name="includedAccountId"></param>
        /// <returns>Streaming feed of latest matches.</returns>
        Task<IList<ProMatch>> GetFeedAsync(
            long? sequenceNumber = null,
            int? gameMode = null,
            int? leagueId = null,
            long? includedAccountId = null);
    }
}
