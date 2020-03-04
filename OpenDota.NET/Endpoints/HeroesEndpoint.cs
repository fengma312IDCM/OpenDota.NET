namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Heroes;

    public class HeroesEndpoint : IHeroesEndpoint
    {
        private readonly Requester requester;

        public HeroesEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <inheritdoc />
        public async Task<List<Hero>> GetHeroesAsync() =>
            await this.requester.GetResponseAsync<List<Hero>>("heroes");

        /// <inheritdoc />
        public async Task<List<HeroMatch>> GetHeroMatchesAsync(int heroId) =>
            await this.requester.GetResponseAsync<List<HeroMatch>>($"heroes/{heroId}/matches");

        /// <inheritdoc />
        public async Task<List<HeroMatchup>> GetHeroMatchupsAsync(int heroId) =>
            await this.requester.GetResponseAsync<List<HeroMatchup>>($"heroes/{heroId}/matchups");

        /// <inheritdoc />
        public async Task<List<HeroDuration>> GetHeroDurationsAsync(int heroId) =>
            await this.requester.GetResponseAsync<List<HeroDuration>>($"heroes/{heroId}/durations");

        /// <inheritdoc />
        public async Task<List<HeroPlayer>> GetHeroPlayersAsync(int heroId) =>
            await this.requester.GetResponseAsync<List<HeroPlayer>>($"heroes/{heroId}/players");
    }
}
