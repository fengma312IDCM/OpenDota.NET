namespace OpenDotaDotNet.Endpoints
{
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Rankings;

    public interface IRankingEndpoint
    {
        /// <summary>
        /// Top players by hero
        /// </summary>
        /// <param name="heroId"></param>
        /// <returns></returns>
        Task<HeroRanking> GetHeroRankingsAsync(int heroId);
    }
}
