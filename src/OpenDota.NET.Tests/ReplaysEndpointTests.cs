namespace OpenDota.NET.Tests
{
    using System.Linq;
    using System.Threading.Tasks;

    using OpenDotaDotNet;

    using Xunit;
    using Xunit.Abstractions;

    public class ReplaysEndpointTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        private readonly OpenDotaApi openDotaApi;

        public ReplaysEndpointTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
            this.openDotaApi = new OpenDotaApi();
        }

        [Fact]
        public async Task TestGetReplayData()
        {
            var proMatches = await this.openDotaApi.ProMatches.GetProMatchesAsync();
            var result =
                await this.openDotaApi.Replays.GetReplayDataAsync(proMatches.Select(x => x.MatchId).Take(2).ToList());
            this.testOutputHelper.WriteLine(result.ToJsonString());

            Assert.Equal(2, result.Count);
            Assert.True(result.All(x => x.MatchId > 0));
            Assert.True(result.All(x => x.Cluster > 0));
            Assert.True(result.All(x => x.ReplaySalt > 0));
            Assert.True(result.All(x => x.SeriesId > 0));
            Assert.True(result.All(x => x.SeriesType > 0));
        }
    }
}
