namespace OpenDota.NET.Tests
{
    using System.Threading.Tasks;

    using OpenDotaDotNet;

    using Xunit;
    using Xunit.Abstractions;

    public class StatusEndpointTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        private readonly OpenDotaApi openDotaApi;

        public StatusEndpointTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
            this.openDotaApi = new OpenDotaApi();
        }

        [Fact]
        public async Task TestGetServiceStatistics()
        {
            var result = await this.openDotaApi.Status.GetServiceStatisticsAsync();
            this.testOutputHelper.WriteLine(result.ToJsonString());
            Assert.True(result.ApiHitsLastDay > 0);
            Assert.True(result.ApiHitsUiLastDay > 0);
            Assert.True(result.BackupRetrieverLastDay > 0);
            Assert.True(result.BenchmarksQueue >= 0);
            Assert.True(result.CountsQueue >= 0);
            Assert.True(result.FeedLastDay >= 0);
            Assert.True(result.FhQueue >= 0);
            Assert.True(result.FullHistoryLastDay > 0);
            Assert.True(result.GcQueue >= 0);
            Assert.True(result.MatchesLastDay > 0);
            Assert.True(result.MatchesLastHour > 0);
            Assert.True(result.MmrQueue >= 0);
            Assert.True(result.ParsedMatchesLastDay > 0);
            Assert.True(result.RequestsLastDay > 0);
            Assert.True(result.RetrieverMatchesLastDay > 0);
            Assert.True(result.ScenariosQueue >= 0);
            Assert.True(result.TrackedPlayers > 0);
            Assert.True(result.UserPlayers > 0);
            Assert.True(result.WebHooksLastDay > 0);
            Assert.True(result.ApiPaths.Count > 0);
            Assert.True(result.Retriever.Count > 0);
            Assert.True(result.LastAddedMatches.Count > 0);
            Assert.True(result.LastParsed.Count > 0);
            Assert.True(result.LoadTimes.Count > 0);
            Assert.True(result.Health.CassandraUsage.Timestamp > 0);
            Assert.True(result.Health.GcDelay.Timestamp > 0);
            Assert.True(result.Health.ParseDelay.Timestamp > 0);
            Assert.True(result.Health.PostgresUsage.Timestamp > 0);
            Assert.True(result.Health.RedisUsage.Timestamp > 0);
            Assert.True(result.Health.SeqNumDelay.Timestamp > 0);
            Assert.True(result.Health.SteamApi.Timestamp > 0);
            Assert.True(result.Health.CassandraUsage.Threshold > 0);
            Assert.True(result.Health.GcDelay.Threshold > 0);
            Assert.True(result.Health.ParseDelay.Threshold > 0);
            Assert.True(result.Health.PostgresUsage.Threshold > 0);
            Assert.True(result.Health.RedisUsage.Threshold > 0);
            Assert.True(result.Health.SeqNumDelay.Threshold > 0);
            Assert.True(result.Health.SteamApi.Threshold > 0);
            Assert.True(result.Health.CassandraUsage.Metric >= 0);
            Assert.True(result.Health.GcDelay.Metric >= 0);
            Assert.True(result.Health.ParseDelay.Metric >= 0);
            Assert.True(result.Health.PostgresUsage.Metric >= 0);
            Assert.True(result.Health.RedisUsage.Metric >= 0);
            Assert.True(result.Health.SeqNumDelay.Metric <= 0);
            Assert.True(result.Health.SteamApi.Metric >= 0);
        }
    }
}
