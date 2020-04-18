namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Scenarios;

    public interface IScenariosEndpoint
    {
        /// <summary>
        /// Gets win rates for certain item timings on a hero for items that cost at least 1400 gold.
        /// </summary>
        /// <param name="item">Filter by item name e.g. "spirit_vessel".</param>
        /// <param name="heroId">Hero ID.</param>
        /// <returns>Win rates for certain item timings on a hero for items that cost at least 1400 gold.</returns>
        Task<IEnumerable<HeroItemTiming>> GetWinRateForCertainItemTimingsOnHeroesAsync(string item = null, int? heroId = null);

        /// <summary>
        /// Gets win rates for heroes in certain lane roles.
        /// </summary>
        /// <param name="laneRole">Filter by lane role 1-4 (Safe, Mid, Off, Jungle).</param>
        /// <param name="heroId">Hero ID.</param>
        /// <returns>Win rates for heroes in certain lane roles.</returns>
        Task<IEnumerable<HeroLaneRoleWinrate>> GetWinRateForHeroesInCertainLaneRolesAsync(int? laneRole = null, int? heroId = null);

        /// <summary>
        /// Gets miscellaneous team scenarios.
        /// </summary>
        /// <param name="scenario">Example value: pos_chat_1min,neg_chat_1min,courier_kill,first_blood.</param>
        /// <returns>Miscellaneous team scenarios.</returns>
        Task<IEnumerable<MiscellaneousTeamScenario>> GetMiscellaneousTeamScenariosAsync(string scenario = null);
    }
}
