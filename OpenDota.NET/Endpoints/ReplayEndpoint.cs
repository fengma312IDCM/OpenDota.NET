using Newtonsoft.Json;
using OpenDotaDotNet.Interfaces;
using OpenDotaDotNet.Models.Replays;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Endpoints
{
    public class ReplayEndpoint : IReplayEndpoint
    {
        private const string ReplayData = "replays";

        private readonly Requester requester;

        public ReplayEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Get data to construct a replay URL with
        /// </summary>
        /// <param name="matchIds">Match IDs (array)</param>
        /// <returns></returns>
        public async Task<List<Replay>> GetReplayDataAsync(List<long> matchIds)
        {
            var addedArguments = CreateArgumentListForReplaysRequest(matchIds);

            var response = await this.requester.GetRequestResponseMessageAsync(ReplayData, addedArguments);

            response.EnsureSuccessStatusCode();

            var heroBenchmarks = JsonConvert.DeserializeObject<List<Replay>>(await response.Content.ReadAsStringAsync());

            return heroBenchmarks;
        }

        #region Helper
        private List<string> CreateArgumentListForReplaysRequest(List<long> matchIds = null)
        {
            var addedArguments = new List<string>();

            if (matchIds != null)
            {
                foreach(var matchId in matchIds)
                {
                    addedArguments.Add($@"match_id={matchId}");
                }
            }

            return addedArguments;
        }
        #endregion
    }
}
