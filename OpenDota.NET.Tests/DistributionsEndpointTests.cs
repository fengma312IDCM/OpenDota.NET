namespace OpenDota.NET.Tests
{
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
            this.openDotaApi = OpenDotaApi.GetInstance();
        }

        [Fact]
        public async Task TestGetDistributions()
        {
            var result = await this.openDotaApi.Distributions.GetDistributionsAsync();
            this.testOutputHelper.WriteLine(result.ToJsonString());

            Assert.Equal(result.Ranks.RowCount, result.Ranks.Rows.Count);
            Assert.True(result.Ranks.Rows.Count > 0);
            Assert.True(result.Ranks.Fields.Count > 0);
            Assert.Equal(result.Mmr.RowCount, result.Mmr.Rows.Count);
            Assert.True(result.Mmr.Rows.Count > 0);
            Assert.True(result.Mmr.Fields.Count > 0);
            Assert.Equal(result.CountryMmr.RowCount, result.CountryMmr.Rows.Count);
            Assert.True(result.CountryMmr.Rows.Count > 0);
            Assert.True(result.CountryMmr.Fields.Count > 0);
        }
    }
}
