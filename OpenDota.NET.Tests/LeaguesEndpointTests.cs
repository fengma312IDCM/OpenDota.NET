namespace OpenDota.NET.Tests
{
    using System.Linq;
    using System.Threading.Tasks;

    using OpenDotaDotNet;
    using OpenDotaDotNet.Models.Leagues;

    using Xunit;
    using Xunit.Abstractions;

    public class LeaguesEndpointTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        private readonly OpenDotaApi openDotaApi;

        public LeaguesEndpointTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
            this.openDotaApi = OpenDotaApi.GetInstance();
        }

        [Fact]
        public async Task TestGetLeagues()
        {
            var result = await this.openDotaApi.League.GetLeaguesAsync();
            this.testOutputHelper.WriteLine(result.ToJsonString());

            Assert.True(result.Count >= 3322);
            Assert.Contains(result, x => x.Tier == LeagueTier.Amateur);
            Assert.Contains(result, x => x.Tier == LeagueTier.Excluded);
            Assert.Contains(result, x => x.Tier == LeagueTier.Premium);
            Assert.Contains(result, x => x.Tier == LeagueTier.Professional);
            Assert.Contains(result, x => x.Leagueid > 0);
            Assert.True(result.All(x => !string.IsNullOrEmpty(x.Name)));
            Assert.Contains(result, x => !string.IsNullOrEmpty(x.Banner));
            Assert.Contains(result, x => !string.IsNullOrEmpty(x.Ticket));
        }
    }
}
