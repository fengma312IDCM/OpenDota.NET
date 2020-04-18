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
        public async Task<IEnumerable<HeroItemTiming>> GetWinRateForCertainItemTimingsOnHeroesAsync(string item = null, int? heroId = null) =>
            await this.requester.GetResponseAsync<IEnumerable<HeroItemTiming>>(
                "scenarios/itemTimings",
                this.GetArguments(item, heroId));

        /// <inheritdoc />
        public async Task<IEnumerable<HeroLaneRoleWinrate>> GetWinRateForHeroesInCertainLaneRolesAsync(int? laneRole = null, int? heroId = null) =>
            await this.requester.GetResponseAsync<IEnumerable<HeroLaneRoleWinrate>>(
                "scenarios/laneRoles",
                this.GetArguments(null, heroId, laneRole));

        /// <inheritdoc />
        public async Task<IEnumerable<MiscellaneousTeamScenario>> GetMiscellaneousTeamScenariosAsync(string scenario = null) =>
            await this.requester.GetResponseAsync<IEnumerable<MiscellaneousTeamScenario>>(
                "scenarios/misc",
                this.GetArguments(null, null, null, scenario));

        private IEnumerable<string> GetArguments(string item = null, int? heroId = null, int? laneRole = null, string scenario = null)
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
