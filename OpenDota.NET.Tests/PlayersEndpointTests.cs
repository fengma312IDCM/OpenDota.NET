namespace OpenDota.NET.Tests
{
    using System.Linq;
    using System.Threading.Tasks;

    using OpenDotaDotNet;

    using Xunit;
    using Xunit.Abstractions;

    public class PlayersEndpointTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        private readonly OpenDotaApi openDotaApi;

        public PlayersEndpointTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
            this.openDotaApi = new OpenDotaApi();
        }

        [Fact]
        public async Task TestGetPlayerById()
        {
            var result = await this.openDotaApi.Players.GetPlayerByIdAsync(34505203);
            this.testOutputHelper.WriteLine(result.ToJsonString());
        }

        [Fact]
        public async Task TestGetPlayerWinLossById()
        {
            var result = await this.openDotaApi.Players.GetPlayerWinLossByIdAsync(34505203);
            this.testOutputHelper.WriteLine(result.ToJsonString());
        }

        [Fact]
        public async Task TestGetPlayerRecentMatches()
        {
            var result = await this.openDotaApi.Players.GetPlayerRecentMatchesAsync(34505203);
            this.testOutputHelper.WriteLine(result.ToJsonString());
        }

        [Fact]
        public async Task TestGetPlayerMatches()
        {
            var result = await this.openDotaApi.Players.GetPlayerMatchesAsync(34505203);
            this.testOutputHelper.WriteLine(result.ToJsonString());
        }

        [Fact]
        public async Task TestGetPlayerHeroes()
        {
            var result = await this.openDotaApi.Players.GetPlayerHeroesAsync(34505203);
            this.testOutputHelper.WriteLine(result.ToJsonString());
        }

        [Fact]
        public async Task TestGetPlayerPeers()
        {
            var result = await this.openDotaApi.Players.GetPlayerPeersAsync(34505203);
            this.testOutputHelper.WriteLine(result.ToJsonString());
        }

        [Fact]
        public async Task TestGetPlayerPros()
        {
            var result = await this.openDotaApi.Players.GetPlayerProsAsync(34505203);
            this.testOutputHelper.WriteLine(result.ToJsonString());
        }

        [Fact]
        public async Task TestGetPlayerTotals()
        {
            var result = await this.openDotaApi.Players.GetPlayerTotalsAsync(34505203);
            this.testOutputHelper.WriteLine(result.ToJsonString());
        }

        [Fact]
        public async Task TestGetPlayerCounts()
        {
            var result = await this.openDotaApi.Players.GetPlayerCountsAsync(34505203);
            this.testOutputHelper.WriteLine(result.ToJsonString());
        }

        [Fact]
        public async Task TestGetPlayerHistograms()
        {
            var result = await this.openDotaApi.Players.GetPlayerHistogramsAsync(34505203, "comeback");
            this.testOutputHelper.WriteLine(result.ToJsonString());
        }

        [Fact]
        public async Task TestGetPlayerWardMap()
        {
            var result = await this.openDotaApi.Players.GetPlayerWardMapAsync(34505203);
            this.testOutputHelper.WriteLine(result.ToJsonString());
        }

        [Fact]
        public async Task TestGetPlayerWordCloud()
        {
            var result = await this.openDotaApi.Players.GetPlayerWordCloudAsync(34505203);
            this.testOutputHelper.WriteLine(result.ToJsonString());
        }

        [Fact]
        public async Task TestGetPlayerRatings()
        {
            var result = await this.openDotaApi.Players.GetPlayerRatingsAsync(34505203);
            this.testOutputHelper.WriteLine(result.ToJsonString());
        }

        [Fact]
        public async Task TestGetPlayerHeroRankings()
        {
            var result = await this.openDotaApi.Players.GetPlayerHeroRankingsAsync(34505203);
            this.testOutputHelper.WriteLine(result.ToJsonString());
        }
    }
}
