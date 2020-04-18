namespace OpenDota.NET.Tests
{
    using System.Linq;
    using System.Threading.Tasks;

    using OpenDotaDotNet;

    using Xunit;
    using Xunit.Abstractions;

    public class DistributionsEndpointTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        private readonly OpenDotaApi openDotaApi;

        public DistributionsEndpointTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
            this.openDotaApi = new OpenDotaApi();
        }

        [Fact]
        public async Task TestGetDistributions()
        {
            var result = await this.openDotaApi.Distributions.GetDistributionsAsync();
            this.testOutputHelper.WriteLine(result.ToJsonString());

            Assert.Equal(result.Ranks.RowCount, result.Ranks.Rows.Count());
            Assert.True(result.Ranks.Rows.Any());
            Assert.True(result.Ranks.Fields.Any());
            Assert.Equal(result.Mmr.RowCount, result.Mmr.Rows.Count());
            Assert.True(result.Mmr.Rows.Any());
            Assert.True(result.Mmr.Fields.Any());
            Assert.Equal(result.CountryMmr.RowCount, result.CountryMmr.Rows.Count());
            Assert.True(result.CountryMmr.Rows.Any());
            Assert.True(result.CountryMmr.Fields.Any());
        }
    }
}
