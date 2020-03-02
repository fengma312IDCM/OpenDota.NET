namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.HeroStats;

    public interface IHeroStatsEndpoint
    {
        /// <summary>
        /// Get stats about hero performance in recent matches
        /// </summary>
        /// <returns></returns>
        Task<List<HeroStats>> GetHeroStatsAsync();
    }
}
