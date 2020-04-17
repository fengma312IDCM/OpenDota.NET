namespace OpenDota.NET.Tests
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using OpenDotaDotNet;
    using OpenDotaDotNet.Models.Leagues;

    using Xunit;
    using Xunit.Abstractions;

    public class MatchesEndpointTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        private readonly OpenDotaApi openDotaApi;

        public MatchesEndpointTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
            this.openDotaApi = new OpenDotaApi();
        }

        [Fact]
        public async Task TestGetMatchById()
        {
            var result = await this.openDotaApi.Matches.GetMatchByIdAsync(4986133311);
            this.testOutputHelper.WriteLine(result.ToJsonString());
        }
    }
}
