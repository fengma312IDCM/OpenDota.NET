namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Heroes;

    public class HeroEndpoint : IHeroEndpoint
    {
        private readonly Requester requester;

        public HeroEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Get hero data.
        /// </summary>
        /// <returns>Hero data.</returns>
        public async Task<List<Hero>> GetHeroesAsync() =>
            await this.requester.GetResponseAsync<List<Hero>>("heroes");

        /// <summary>
        /// Get recent matches with a hero.
        /// </summary>
        /// <param name="heroId"></param>
        /// <returns>Recent matches with a hero.</returns>
        public async Task<List<HeroMatch>> GetHeroMatchesAsync(int heroId) =>
            await this.requester.GetResponseAsync<List<HeroMatch>>($"heroes/{heroId}/matches");

        /// <summary>
        /// Get results against other heroes for a hero.
        /// </summary>
        /// <param name="heroId"></param>
        /// <returns>Results against other heroes for a hero.</returns>
        public async Task<List<HeroMatchup>> GetHeroMatchupsAsync(int heroId) =>
            await this.requester.GetResponseAsync<List<HeroMatchup>>($"heroes/{heroId}/matchups");

        /// <summary>
        /// Get hero performance over a range of match durations.
        /// </summary>
        /// <param name="heroId"></param>
        /// <returns>Hero performance over a range of match durations.</returns>
        public async Task<List<HeroDuration>> GetHeroDurationsAsync(int heroId) =>
            await this.requester.GetResponseAsync<List<HeroDuration>>($"heroes/{heroId}/durations");

        /// <summary>
        /// Get players who have played this hero.
        /// </summary>
        /// <param name="heroId"></param>
        /// <returns>Players who have played this hero.</returns>
        public async Task<List<HeroPlayer>> GetHeroPlayersAsync(int heroId) =>
            await this.requester.GetResponseAsync<List<HeroPlayer>>($"heroes/{heroId}/players");
    }
}
