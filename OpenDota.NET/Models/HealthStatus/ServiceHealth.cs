namespace OpenDotaDotNet.Models.HealthStatus
{
    using System.Text.Json.Serialization;

    public class ServiceHealth
    {
        [JsonPropertyName("parseDelay")]
        public ServiceUsage ParseDelay { get; set; }

        [JsonPropertyName("cassandraUsage")]
        public ServiceUsage CassandraUsage { get; set; }

        [JsonPropertyName("redisUsage")]
        public ServiceUsage RedisUsage { get; set; }

        [JsonPropertyName("seqNumDelay")]
        public ServiceUsage SeqNumDelay { get; set; }

        [JsonPropertyName("postgresUsage")]
        public ServiceUsage PostgresUsage { get; set; }

        [JsonPropertyName("steamApi")]
        public ServiceUsage SteamApi { get; set; }

        [JsonPropertyName("gcDelay")]
        public ServiceUsage GcDelay { get; set; }
    }
}
