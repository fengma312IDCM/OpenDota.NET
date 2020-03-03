namespace OpenDotaDotNet.Models.Distributions
{
    using System.Text.Json.Serialization;

    public class Field
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("tableID")]
        public long TableId { get; set; }

        [JsonPropertyName("columnID")]
        public long ColumnId { get; set; }

        [JsonPropertyName("dataTypeID")]
        public long DataTypeId { get; set; }

        [JsonPropertyName("dataTypeSize")]
        public long DataTypeSize { get; set; }

        [JsonPropertyName("dataTypeModifier")]
        public long DataTypeModifier { get; set; }

        [JsonPropertyName("format")]
        public string Format { get; set; }
    }
}
