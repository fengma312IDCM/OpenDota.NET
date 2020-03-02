namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    using OpenDotaDotNet.Models.Leagues;

    public class LeagueEndpoint : ILeagueEndpoint
    {
        private const string Leagues = "leagues";

        private readonly Requester requester;

        public LeagueEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Get league data.
        /// </summary>
        /// <returns>League data.</returns>
        public async Task<List<League>> GetLeaguesAsync()
        {
            var response = await this.requester.GetRequestResponseMessageAsync(Leagues);

            response.EnsureSuccessStatusCode();

            var leagues = JsonConvert.DeserializeObject<List<League>>(await response.Content.ReadAsStringAsync());

            return leagues;
        }
    }
}
