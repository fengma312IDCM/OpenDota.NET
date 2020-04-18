namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Replays;

    public class ReplaysEndpoint : IReplaysEndpoint
    {
        private readonly Requester requester;

        public ReplaysEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Get data to construct a replay URL with.
        /// </summary>
        /// <param name="matchIds">Match IDs (array).</param>
        /// <returns>Data to construct a replay URL with.</returns>
        public async Task<IEnumerable<Replay>> GetReplayDataAsync(IEnumerable<long> matchIds) =>
            await this.requester.GetResponseAsync<IEnumerable<Replay>>(
                "replays",
                matchIds?.Select(matchId => $@"match_id={matchId}"));
    }
}
