namespace OpenDota.NET.Tests
{
    using System.Linq;
    using System.Threading.Tasks;

    using OpenDotaDotNet;

    using Xunit;
    using Xunit.Abstractions;

    public class BenchmarksEndpointTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        private readonly OpenDotaApi openDotaApi;

        public BenchmarksEndpointTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
            this.openDotaApi = new OpenDotaApi();
        }

        [Fact]
        public async Task TestGetHeroBenchmark()
        {
            var heroId = 2;
            var result = await this.openDotaApi.Benchmarks.GetHeroBenchmarkAsync(heroId);
            this.testOutputHelper.WriteLine(result.ToJsonString());

            Assert.Equal(heroId, result.HeroId);
            Assert.NotNull(result.Result);
            Assert.Equal(11, result.Result.GoldPerMin.Count());
            Assert.Equal(11, result.Result.XpPerMin.Count());
            Assert.Equal(11, result.Result.KillsPerMin.Count());
            Assert.Equal(11, result.Result.LastHitsPerMin.Count());
            Assert.Equal(11, result.Result.HeroDamagePerMin.Count());
            Assert.Equal(11, result.Result.HeroHealingPerMin.Count());
            Assert.Equal(11, result.Result.TowerDamage.Count());
            Assert.Equal(11, result.Result.StunsPerMin.Count());
            Assert.Equal(11, result.Result.LastHits10Minute.Count());
        }
    }
}
