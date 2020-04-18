namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Scenarios;

    public class ScenariosEndpoint : IScenariosEndpoint
    {
        private readonly Requester requester;

        public ScenariosEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <inheritdoc />
        public async Task<List<HeroItemTiming>> GetWinRateForCertainItemTimingsOnHeroesAsync(string item = null, int? heroId = null) =>
            await this.requester.GetResponseAsync<List<HeroItemTiming>>(
                "scenarios/itemTimings",
                this.CreateArgumentListForScenariosRequest(item, heroId));

        /// <inheritdoc />
        public async Task<List<HeroLaneRoleWinrate>> GetWinRateForHeroesInCertainLaneRolesAsync(int? laneRole = null, int? heroId = null) =>
            await this.requester.GetResponseAsync<List<HeroLaneRoleWinrate>>(
                "scenarios/laneRoles",
                this.CreateArgumentListForScenariosRequest(null, heroId, laneRole));

        /// <inheritdoc />
        public async Task<List<MiscellaneousTeamScenario>> GetMiscellaneousTeamScenariosAsync(string scenario = null) =>
            await this.requester.GetResponseAsync<List<MiscellaneousTeamScenario>>(
                "scenarios/misc",
                this.CreateArgumentListForScenariosRequest(null, null, null, scenario));

        private List<string> CreateArgumentListForScenariosRequest(string item = null, int? heroId = null, int? laneRole = null, string scenario = null)
        {
            var addedArguments = new List<string>();

            if (item != null)
            {
                addedArguments.Add($"item={item}");
            }

            if (heroId != null)
            {
                addedArguments.Add($"hero_id={heroId}");
            }

            if (laneRole != null)
            {
                addedArguments.Add($"lane_role={laneRole}");
            }

            if (scenario != null)
            {
                addedArguments.Add($"scenario={scenario}");
            }

            return addedArguments;
        }
    }
}
