namespace OpenDota.NET.Tests
{
    using System.Threading.Tasks;

    using OpenDotaDotNet;

    using Xunit;
    using Xunit.Abstractions;

    public class HealthEndpointTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        private readonly OpenDotaApi openDotaApi;

        public HealthEndpointTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
            this.openDotaApi = OpenDotaApi.GetInstance();
        }

        [Fact]
        public async Task TestGetServiceHealthData()
        {
            var result = await this.openDotaApi.Health.GetServiceHealthDataAsync();
            this.testOutputHelper.WriteLine(result.ToJsonString());
            Assert.True(result.CassandraUsage.Timestamp > 0);
            Assert.True(result.GcDelay.Timestamp > 0);
            Assert.True(result.ParseDelay.Timestamp > 0);
            Assert.True(result.PostgresUsage.Timestamp > 0);
            Assert.True(result.RedisUsage.Timestamp > 0);
            Assert.True(result.SeqNumDelay.Timestamp > 0);
            Assert.True(result.SteamApi.Timestamp > 0);
            Assert.True(result.CassandraUsage.Threshold > 0);
            Assert.True(result.GcDelay.Threshold > 0);
            Assert.True(result.ParseDelay.Threshold > 0);
            Assert.True(result.PostgresUsage.Threshold > 0);
            Assert.True(result.RedisUsage.Threshold > 0);
            Assert.True(result.SeqNumDelay.Threshold > 0);
            Assert.True(result.SteamApi.Threshold > 0);
            Assert.True(result.CassandraUsage.Metric >= 0);
            Assert.True(result.GcDelay.Metric >= 0);
            Assert.True(result.ParseDelay.Metric >= 0);
            Assert.True(result.PostgresUsage.Metric >= 0);
            Assert.True(result.RedisUsage.Metric >= 0);
            Assert.True(result.SeqNumDelay.Metric <= 0);
            Assert.True(result.SteamApi.Metric >= 0);
        }
    }
}
