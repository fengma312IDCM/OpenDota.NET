namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    using OpenDotaDotNet.Models.HeroStats;

    public class HeroStatsEndpoint : IHeroStatsEndpoint
    {
        private const string HeroStats = "heroStats";

        private readonly Requester requester;

        public HeroStatsEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Get stats about hero performance in recent matches.
        /// </summary>
        /// <returns>Stats about hero performance in recent matches.</returns>
        public async Task<List<HeroStats>> GetHeroStatsAsync()
        {
            var response = await this.requester.GetRequestResponseMessageAsync(HeroStats);

            response.EnsureSuccessStatusCode();

            var heroStats = JsonConvert.DeserializeObject<List<HeroStats>>(await response.Content.ReadAsStringAsync());

            return heroStats;
        }
    }
}
