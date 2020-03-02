namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    using OpenDotaDotNet.Models.Replays;

    public class ReplayEndpoint : IReplayEndpoint
    {
        private const string ReplayData = "replays";

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
        public async Task<List<Replay>> GetReplayDataAsync(List<long> matchIds)
        {
            var addedArguments = this.CreateArgumentListForReplaysRequest(matchIds);

            var response = await this.requester.GetRequestResponseMessageAsync(ReplayData, addedArguments);

            response.EnsureSuccessStatusCode();

            var heroBenchmarks = JsonConvert.DeserializeObject<List<Replay>>(await response.Content.ReadAsStringAsync());

            return heroBenchmarks;
        }

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
