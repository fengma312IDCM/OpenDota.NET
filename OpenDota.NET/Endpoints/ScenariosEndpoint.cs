namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    using OpenDotaDotNet.Models.Scenarios;

    public class ScenariosEndpoint : IScenariosEndpoint
    {
        private const string WinRateForCertainItemTimings = "scenarios/itemTimings";
        private const string WinRateForHeroesInCertainLaneRole = "scenarios/laneRoles";
        private const string MiscellaneousTeamScenarios = "scenarios/misc";

        private readonly Requester requester;

        public ScenariosEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <summary>
        /// Gets win rates for certain item timings on a hero for items that cost at least 1400 gold.
        /// </summary>
        /// <param name="item">Filter by item name e.g. "spirit_vessel".</param>
        /// <param name="heroId">Hero ID.</param>
        /// <returns>Win rates for certain item timings on a hero for items that cost at least 1400 gold.</returns>
        public async Task<List<HeroItemTiming>> GetWinRateForCertainItemTimingsOnHeroesAsync(string item = null, int? heroId = null)
        {
            var addedArguments = this.CreateArgumentListForScenariosRequest(item, heroId);

            var response = await this.requester.GetRequestResponseMessageAsync(WinRateForCertainItemTimings, addedArguments);

            response.EnsureSuccessStatusCode();

            var heroItemTimings = JsonConvert.DeserializeObject<List<HeroItemTiming>>(await response.Content.ReadAsStringAsync());

            return heroItemTimings;
        }

        /// <summary>
        /// Gets win rates for heroes in certain lane roles.
        /// </summary>
        /// <param name="laneRole">Filter by lane role 1-4 (Safe, Mid, Off, Jungle).</param>
        /// <param name="heroId">Hero ID.</param>
        /// <returns>Win rates for heroes in certain lane roles.</returns>
        public async Task<List<HeroLaneRoleWinrate>> GetWinRateForHeroesInCertainLaneRolesAsync(int? laneRole = null, int? heroId = null)
        {
            var addedArguments = this.CreateArgumentListForScenariosRequest(null, heroId, laneRole);

            var response = await this.requester.GetRequestResponseMessageAsync(WinRateForHeroesInCertainLaneRole, addedArguments);

            response.EnsureSuccessStatusCode();

            var heroBenchmarks = JsonConvert.DeserializeObject<List<HeroLaneRoleWinrate>>(await response.Content.ReadAsStringAsync());

            return heroBenchmarks;
        }

        /// <summary>
        /// Gets miscellaneous team scenarios.
        /// </summary>
        /// <param name="scenario">Example value: pos_chat_1min,neg_chat_1min,courier_kill,first_blood.</param>
        /// <returns>Miscellaneous team scenarios.</returns>
        public async Task<List<MiscellaneousTeamScenario>> GetMiscellaneousTeamScenariosAsync(string scenario = null)
        {
            var addedArguments = this.CreateArgumentListForScenariosRequest(null, null, null, scenario);

            var response = await this.requester.GetRequestResponseMessageAsync(MiscellaneousTeamScenarios, addedArguments);

            response.EnsureSuccessStatusCode();

            var heroBenchmarks = JsonConvert.DeserializeObject<List<MiscellaneousTeamScenario>>(await response.Content.ReadAsStringAsync());

            return heroBenchmarks;
        }

        private List<string> CreateArgumentListForScenariosRequest(string item = null, int? heroId = null, int? laneRole = null, string scenario = null)
        {
            var addedArguments = new List<string>();

            if (item != null)
            {
                addedArguments.Add($@"item={item}");
            }

            if (heroId != null)
            {
                addedArguments.Add($@"hero_id={heroId}");
            }

            if (laneRole != null)
            {
                addedArguments.Add($@"lane_role={laneRole}");
            }

            if (scenario != null)
            {
                addedArguments.Add($@"scenario={scenario}");
            }

            return addedArguments;
        }
    }
}
