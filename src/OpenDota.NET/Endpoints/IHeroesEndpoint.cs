namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Heroes;

    public interface IHeroesEndpoint
    {
        /// <summary>
        /// Get hero data.
        /// </summary>
        /// <returns>Hero data.</returns>
        Task<IEnumerable<Hero>> GetHeroesAsync();

        /// <summary>
        /// Get recent matches with a hero.
        /// </summary>
        /// <param name="heroId"></param>
        /// <returns>Recent matches with a hero.</returns>
        Task<IEnumerable<HeroMatch>> GetHeroMatchesAsync(int heroId);

        /// <summary>
        /// Get results against other heroes for a hero.
        /// </summary>
        /// <param name="heroId"></param>
        /// <returns>Results against other heroes for a hero.</returns>
        Task<IEnumerable<HeroMatchup>> GetHeroMatchupsAsync(int heroId);

        /// <summary>
        /// Get hero performance over a range of match durations.
        /// </summary>
        /// <param name="heroId"></param>
        /// <returns>Hero performance over a range of match durations.</returns>
        Task<IEnumerable<HeroDuration>> GetHeroDurationsAsync(int heroId);

        /// <summary>
        /// Get players who have played this hero.
        /// </summary>
        /// <param name="heroId"></param>
        /// <returns>Players who have played this hero.</returns>
        Task<IEnumerable<HeroPlayer>> GetHeroPlayersAsync(int heroId);
    }
}
