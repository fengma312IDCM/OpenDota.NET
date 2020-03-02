using Newtonsoft.Json;

using OpenDotaDotNet.Models.Live;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Endpoints
{
    public class LiveEndpoint : ILiveEndpoint
    {
        private const string TopLiveGames = "live";

        private readonly Requester requester;

        public LiveEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Get top currently ongoing live games
        /// </summary>
        /// <returns></returns>
        public async Task<List<LiveGame>> GetTopLiveGamesAsync()
        {
            var response = await this.requester.GetRequestResponseMessageAsync(TopLiveGames);

            response.EnsureSuccessStatusCode();

            var topLiveGames = JsonConvert.DeserializeObject<List<LiveGame>>(await response.Content.ReadAsStringAsync());

            return topLiveGames;
        }
    }
}
