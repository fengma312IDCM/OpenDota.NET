namespace OpenDota.NET.Tests
{
    using System.Linq;
    using System.Threading.Tasks;

    using OpenDotaDotNet;
    using OpenDotaDotNet.Models.Records;

    using Xunit;
    using Xunit.Abstractions;

    public class ScenariosEndpointTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        private readonly OpenDotaApi openDotaApi;

        public ScenariosEndpointTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
            this.openDotaApi = new OpenDotaApi();
        }

        [Fact]
        public async Task TestGetWinRateForCertainItemTimingsOnHeroes()
        {
            const int HeroId = 40;
            const string ItemName = "sange_and_yasha";
            var result =
                await this.openDotaApi.Scenarios.GetWinRateForCertainItemTimingsOnHeroesAsync(ItemName, HeroId);
            this.testOutputHelper.WriteLine(result.ToJsonString());

            Assert.True(result.Count > 0);
            Assert.True(result.All(x => x.Item == ItemName));
            Assert.True(result.All(x => x.HeroId == HeroId));
            Assert.True(result.All(x => x.Time > 0));
            Assert.True(result.All(x => x.Games > 0));
            Assert.True(result.All(x => x.Wins > 0));
        }

        [Fact]
        public async Task TestGetWinRateForHeroesInCertainLaneRoles()
        {
            const int LaneId = 3; // Offlane
            const int HeroId = 40; // Venomancer
            var result =
                await this.openDotaApi.Scenarios.GetWinRateForHeroesInCertainLaneRolesAsync(3, 40);
            this.testOutputHelper.WriteLine(result.ToJsonString());

            Assert.True(result.Count > 0);
            Assert.True(result.All(x => x.LaneRole == LaneId));
            Assert.True(result.All(x => x.HeroId == HeroId));
            Assert.True(result.All(x => x.Time > 0));
            Assert.True(result.All(x => x.Games > 0));
            Assert.True(result.All(x => x.Wins > 0));
        }

        [Fact]
        public async Task TestGetMiscellaneousTeamScenarios()
        {
            const string Scenario = "courier_kill";
            var result =
                await this.openDotaApi.Scenarios.GetMiscellaneousTeamScenariosAsync(Scenario);
            this.testOutputHelper.WriteLine(result.ToJsonString());

            Assert.True(result.Count > 0);
            Assert.True(result.All(x => x.Scenario == Scenario));
            Assert.True(result.All(x => x.Games > 0));
            Assert.True(result.All(x => x.Wins > 0));
            Assert.True(result.All(x => x.Region > 0));
            Assert.True(result.Count(x => x.IsRadiant) == result.Count(x => !x.IsRadiant));
        }
    }
}
