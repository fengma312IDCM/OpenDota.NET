namespace OpenDota.NET.Tests
{
    using System.Linq;
    using System.Threading.Tasks;

    using OpenDotaDotNet;

    using Xunit;
    using Xunit.Abstractions;

    public class PublicMatchesEndpointTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        private readonly OpenDotaApi openDotaApi;

        public PublicMatchesEndpointTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
            this.openDotaApi = new OpenDotaApi();
        }

        [Fact]
        public async Task TestGetPublicMatches()
        {
            var result = await this.openDotaApi.PublicMatches.GetPublicMatchesAsync();
            this.testOutputHelper.WriteLine(result.ToJsonString());

            Assert.True(result.All(x => x.MatchId > 0));
            Assert.Contains(result, x => x.AvgMmr > 0);
            Assert.True(result.All(x => x.AvgRankTier > 0));
            Assert.True(result.All(x => x.Cluster > 0));
            Assert.True(result.All(x => x.Duration > 0));
            Assert.True(result.All(x => x.GameMode > 0));
            Assert.True(result.All(x => x.LobbyType >= 0));
            Assert.True(result.All(x => x.MatchSeqNum > 0));
            Assert.True(result.All(x => !x.NumMmr.HasValue || x.NumMmr > 0));
            Assert.True(result.All(x => x.NumRankTier > 0));
            Assert.True(result.All(x => x.StartTime > 0));
            Assert.True(result.All(x => x.RadiantTeam.Split(',').Length == 5));
            Assert.True(result.All(x => x.DireTeam.Split(',').Length == 5));
        }
    }
}
