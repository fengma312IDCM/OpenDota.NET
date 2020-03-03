namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Replays;

    public class ReplayEndpoint : IReplayEndpoint
    {
        private readonly Requester requester;

        public ReplayEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Get data to construct a replay URL with.
        /// </summary>
        /// <param name="matchIds">Match IDs (array).</param>
        /// <returns>Data to construct a replay URL with.</returns>
        public async Task<List<Replay>> GetReplayDataAsync(List<long> matchIds) =>
            await this.requester.GetResponseAsync<List<Replay>>(
                "replays",
                this.CreateArgumentListForReplaysRequest(matchIds));

        private List<string> CreateArgumentListForReplaysRequest(IReadOnlyCollection<long> matchIds = null)
        {
            var addedArguments = new List<string>();

            if (matchIds != null)
            {
                foreach (var matchId in matchIds)
                {
                    addedArguments.Add($@"match_id={matchId}");
                }
            }

            return addedArguments;
        }
    }
}
