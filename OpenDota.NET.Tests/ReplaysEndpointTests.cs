namespace OpenDota.NET.Tests
{
    using System.Collections.Generic;
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
            this.openDotaApi = OpenDotaApi.GetInstance();
        }

        [Fact]
        public async Task TestGetReplayData()
        {
            var result = await this.openDotaApi.Replays.GetReplayDataAsync(new List<long> { 5360987052, 5361213941 });
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
