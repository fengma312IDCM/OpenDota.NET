namespace OpenDota.NET.Tests
{
    using System.Linq;
    using System.Threading.Tasks;

    using OpenDotaDotNet;

    using Xunit;
    using Xunit.Abstractions;

    public class FeedEndpointTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        private readonly OpenDotaApi openDotaApi;

        public FeedEndpointTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
            this.openDotaApi = new OpenDotaApi();
        }

        [Fact(Skip = "API key required.")]
        public async Task TestGetFeed()
        {
            var result = await this.openDotaApi.Feed.GetFeedAsync();
            this.testOutputHelper.WriteLine(result.ToJsonString());
        }
    }
}
