namespace OpenDota.NET.Tests
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using OpenDotaDotNet;

    using Xunit;
    using Xunit.Abstractions;

    public class SearchEndpointTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        private readonly OpenDotaApi openDotaApi;

        public SearchEndpointTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
            this.openDotaApi = new OpenDotaApi();
        }

        [Fact]
        public async Task TestGetPlayersByName()
        {
            var result = await this.openDotaApi.Search.GetPlayersByNameAsync("mind_control");
            this.testOutputHelper.WriteLine(result.ToJsonString());

            Assert.Equal(50, result.Count);
            Assert.True(result.All(x => x.AccountId > 0));
            Assert.True(result.All(x => x.Similarity > 0));
            Assert.Contains(result, x => x.LastMatchTime > new DateTime(2000, 1, 1));
            Assert.True(result.All(x => !x.LastMatchTime.HasValue || x.LastMatchTime > new DateTime(2000, 1, 1)));
            Assert.True(result.All(x => !string.IsNullOrWhiteSpace(x.PersonaName)));
            Assert.True(result.All(x => !string.IsNullOrWhiteSpace(x.AvatarFull.ToString())));
        }
    }
}
