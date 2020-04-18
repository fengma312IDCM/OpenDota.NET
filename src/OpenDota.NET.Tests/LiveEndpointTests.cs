namespace OpenDota.NET.Tests
{
    using System.Linq;
    using System.Threading.Tasks;

    using OpenDotaDotNet;

    using Xunit;
    using Xunit.Abstractions;

    public class LiveEndpointTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        private readonly OpenDotaApi openDotaApi;

        public LiveEndpointTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
            this.openDotaApi = new OpenDotaApi();
        }

        [Fact]
        public async Task TestGetTopLiveGames()
        {
            var result = await this.openDotaApi.Live.GetTopLiveGamesAsync();
            this.testOutputHelper.WriteLine(result.ToJsonString());

            Assert.Equal(100, result.Count);
            Assert.True(result.All(x => !string.IsNullOrEmpty(x.LobbyId)));
            Assert.True(result.All(x => x.Players.Count > 0));
        }
    }
}
