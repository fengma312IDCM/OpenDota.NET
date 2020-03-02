namespace OpenDotaDotNet.Models.Request
{
    using System;

    using Newtonsoft.Json;

    public class ParseRequestState
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        [JsonProperty("attempts")]
        public int Attempts { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("next_attempt_time")]
        public DateTimeOffset NextAttemptTime { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("jobId")]
        public long JobId { get; set; }
    }
}
