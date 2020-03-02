namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    using OpenDotaDotNet.Models.ProPlayers;

    public class ProPlayerEndpoint : IProPlayerEndpoint
    {
        private const string ProPlayers = "proPlayers";

        private readonly Requester requester;

        public ProPlayerEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Get list of pro players.
        /// </summary>
        /// <returns>List of pro players.</returns>
        public async Task<List<ProPlayer>> GetProPlayersAsync()
        {
            var response = await this.requester.GetRequestResponseMessageAsync(ProPlayers);

            response.EnsureSuccessStatusCode();

            var proPlayers = JsonConvert.DeserializeObject<List<ProPlayer>>(await response.Content.ReadAsStringAsync());

            return proPlayers;
        }
    }
}
