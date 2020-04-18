namespace OpenDota.NET.Tests
{
    using System.Linq;
    using System.Threading.Tasks;

    using OpenDotaDotNet;

    using Xunit;
    using Xunit.Abstractions;

    public class ProMatchesEndpointTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        private readonly OpenDotaApi openDotaApi;

        public ProMatchesEndpointTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
            this.openDotaApi = new OpenDotaApi();
        }

        [Fact]
        public async Task TestGetProMatches()
        {
            var result = await this.openDotaApi.ProMatches.GetProMatchesAsync();
            this.testOutputHelper.WriteLine(result.ToJsonString());

            Assert.Equal(100, result.Count());
            Assert.True(result.All(x => !string.IsNullOrEmpty(x.LeagueName)));
            Assert.True(result.All(x => x.MatchId > 0));
            Assert.True(result.All(x => x.StartTime > 0));
        }
    }
}
