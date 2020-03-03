namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.HeroStats;

    public class HeroStatsEndpoint : IHeroStatsEndpoint
    {
        private readonly Requester requester;

        public HeroStatsEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Get stats about hero performance in recent matches.
        /// </summary>
        /// <returns>Stats about hero performance in recent matches.</returns>
        public async Task<List<HeroStats>> GetHeroStatsAsync() =>
            await this.requester.GetResponseAsync<List<HeroStats>>("heroStats");
    }
}
