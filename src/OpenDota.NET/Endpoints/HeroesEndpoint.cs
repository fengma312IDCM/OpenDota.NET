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
        public async Task<IEnumerable<Hero>> GetHeroesAsync() =>
            await this.requester.GetResponseAsync<IEnumerable<Hero>>("heroes");

        /// <inheritdoc />
        public async Task<IEnumerable<HeroMatch>> GetHeroMatchesAsync(int heroId) =>
            await this.requester.GetResponseAsync<IEnumerable<HeroMatch>>($"heroes/{heroId}/matches");

        /// <inheritdoc />
        public async Task<IEnumerable<HeroMatchup>> GetHeroMatchupsAsync(int heroId) =>
            await this.requester.GetResponseAsync<IEnumerable<HeroMatchup>>($"heroes/{heroId}/matchups");

        /// <inheritdoc />
        public async Task<IEnumerable<HeroDuration>> GetHeroDurationsAsync(int heroId) =>
            await this.requester.GetResponseAsync<IEnumerable<HeroDuration>>($"heroes/{heroId}/durations");

        /// <inheritdoc />
        public async Task<IEnumerable<HeroPlayer>> GetHeroPlayersAsync(int heroId) =>
            await this.requester.GetResponseAsync<IEnumerable<HeroPlayer>>($"heroes/{heroId}/players");
    }
}
