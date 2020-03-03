namespace OpenDota.NET.Tests
{
    using System.Linq;
    using System.Threading.Tasks;

    using OpenDotaDotNet;

    using Xunit;
    using Xunit.Abstractions;

    public class ProPlayersEndpointTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        private readonly OpenDotaApi openDotaApi;

        public ProPlayersEndpointTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
            this.openDotaApi = OpenDotaApi.GetInstance();
        }

        [Fact]
        public async Task TestGetProPlayers()
        {
            var result = await this.openDotaApi.ProPlayers.GetProPlayersAsync();
            this.testOutputHelper.WriteLine(result.ToJsonString());

            Assert.Contains(result, x => x.Name == "MinD_ContRoL");
            Assert.True(result.All(x => x.SteamId != null));
            Assert.True(result.All(x => !string.IsNullOrEmpty(x.Name)));
            Assert.True(result.All(x => !string.IsNullOrEmpty(x.Avatar.ToString())));
            Assert.True(result.All(x => !string.IsNullOrEmpty(x.AvatarMedium.ToString())));
            Assert.True(result.All(x => !string.IsNullOrEmpty(x.AvatarFull.ToString())));
            Assert.True(result.Count >= 1000);
        }
    }
}
