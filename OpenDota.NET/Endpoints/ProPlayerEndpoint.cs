using Newtonsoft.Json;

using OpenDotaDotNet.Models.ProPlayers;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Endpoints
{
    class ProPlayerEndpoint : IProPlayerEndpoint
    {
        private const string ProPlayers = "proPlayers";

        private readonly Requester requester;

        public ProPlayerEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Get list of pro players
        /// </summary>
        /// <returns></returns>
        public async Task<List<ProPlayer>> GetProPlayersAsync()
        {
            var response = await this.requester.GetRequestResponseMessageAsync(ProPlayers);

            response.EnsureSuccessStatusCode();

            var proPlayers = JsonConvert.DeserializeObject<List<ProPlayer>>(await response.Content.ReadAsStringAsync());

            return proPlayers;
        }
    }
}
