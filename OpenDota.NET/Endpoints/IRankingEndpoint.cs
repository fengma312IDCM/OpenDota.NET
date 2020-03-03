namespace OpenDotaDotNet.Endpoints
{
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Rankings;

    public interface IRankingEndpoint
    {
        /// <summary>
        /// Gets top players by hero.
        /// </summary>
        /// <param name="heroId"></param>
        /// <returns>Top players by hero.</returns>
        Task<HeroRanking> GetHeroRankingsAsync(int heroId);
    }
}
