namespace OpenDota.NET.Tests
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using OpenDotaDotNet;

    using Xunit;
    using Xunit.Abstractions;

    public class RankingsEndpointTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        private readonly OpenDotaApi openDotaApi;

        public RankingsEndpointTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
            this.openDotaApi = new OpenDotaApi();
        }

        [Fact]
        public async Task TestGetHeroRankings()
        {
            const int HeroId = 40;
            var result = await this.openDotaApi.Rankings.GetHeroRankingsAsync(HeroId);
            this.testOutputHelper.WriteLine(result.ToJsonString());

            Assert.Equal(HeroId, result.HeroId);
            Assert.Equal(100, result.Rankings.Count);
            Assert.True(result.Rankings.All(x => x.AccountId > 0));
            Assert.Contains(result.Rankings, x => x.RankTier > 0);
            Assert.True(result.Rankings.All(x => !x.RankTier.HasValue || x.RankTier > 0));
            Assert.True(result.Rankings.All(x => x.Score > 0));
            Assert.Contains(result.Rankings, x => x.LastLogin > new DateTime(2000, 1, 1));
            Assert.True(result.Rankings.All(x => !x.LastLogin.HasValue || x.LastLogin > new DateTime(2000, 1, 1)));
            Assert.Contains(result.Rankings, x => !string.IsNullOrWhiteSpace(x.Name));
            Assert.True(result.Rankings.All(x => !string.IsNullOrWhiteSpace(x.Avatar.ToString())));
            Assert.True(result.Rankings.All(x => !string.IsNullOrWhiteSpace(x.Personaname)));
        }
    }
}
