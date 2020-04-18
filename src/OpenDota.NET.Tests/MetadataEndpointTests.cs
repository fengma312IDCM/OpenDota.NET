namespace OpenDota.NET.Tests
{
    using System.Threading.Tasks;

    using OpenDotaDotNet;

    using Xunit;
    using Xunit.Abstractions;

    public class MetadataEndpointTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        private readonly OpenDotaApi openDotaApi;

        public MetadataEndpointTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
            this.openDotaApi = new OpenDotaApi();
        }

        [Fact]
        public async Task TestGetMetadata()
        {
            var result = await this.openDotaApi.Metadata.GetMetadataAsync();
            this.testOutputHelper.WriteLine(result.ToJsonString());

            Assert.True(result.Cheese.CheeseAmount > 0);
            Assert.True(result.Cheese.Goal > 0);
            Assert.True(result.Scenarios.ItemCost > 0);
            Assert.True(result.Scenarios.GameDurationBucket.Length > 0);
            Assert.True(result.Scenarios.TeamScenariosQueryParams.Length > 0);
            Assert.True(result.Scenarios.Timings.Length > 0);
        }
    }
}
