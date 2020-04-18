namespace OpenDota.NET.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using OpenDotaDotNet;

    using Xunit;
    using Xunit.Abstractions;

    public class FindMatchesEndpointTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        private readonly OpenDotaApi openDotaApi;

        public FindMatchesEndpointTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
            this.openDotaApi = new OpenDotaApi();
        }

        [Fact]
        public async Task TestFindMatchesByHeroesPlayed()
        {
            var result = await this.openDotaApi.FindMatches.FindMatchesByHeroesPlayedAsync(
                             new List<int> { 27, 40 },
                             new List<int> { 1, 2 });
            this.testOutputHelper.WriteLine(result.ToJsonString());

            Assert.Equal(10, result.Count());
            Assert.True(
                result.All(
                    x => (x.TeamA.Contains(27) && x.TeamA.Contains(40))
                         || (x.TeamB.Contains(27) && x.TeamB.Contains(40))));
            Assert.True(
                result.All(
                    x => (x.TeamA.Contains(1) && x.TeamA.Contains(2))
                         || (x.TeamB.Contains(1) && x.TeamB.Contains(2))));
            Assert.True(result.All(x => x.StartTime > 0));
            Assert.True(result.All(x => x.MatchId > 0));
        }
    }
}
