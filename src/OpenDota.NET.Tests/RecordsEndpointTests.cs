namespace OpenDota.NET.Tests
{
    using System.Linq;
    using System.Threading.Tasks;

    using OpenDotaDotNet;
    using OpenDotaDotNet.Models.Records;

    using Xunit;
    using Xunit.Abstractions;

    public class RecordsEndpointTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        private readonly OpenDotaApi openDotaApi;

        public RecordsEndpointTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
            this.openDotaApi = new OpenDotaApi();
        }

        [Fact]
        public async Task TestGetRecordsByField()
        {
            var result = await this.openDotaApi.Records.GetRecordsByFieldAsync(RecordField.Duration);
            this.testOutputHelper.WriteLine(result.ToJsonString());

            Assert.Equal(100, result.Count());
            Assert.True(result.All(x => x.MatchId > 0));
            Assert.True(result.All(x => x.Score > 0));
            Assert.True(result.All(x => x.StartTime > 0));
        }
    }
}
