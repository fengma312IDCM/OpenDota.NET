namespace OpenDotaDotNet.Models.Metadata
{
    using System.Text.Json.Serialization;

    public class User
    {
        [JsonPropertyName("account_id")]
        public int AccountId { get; set; }
    }
}
