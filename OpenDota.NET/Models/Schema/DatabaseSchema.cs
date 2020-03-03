namespace OpenDotaDotNet.Models.Schema
{
    using System.Text.Json.Serialization;

    public class DatabaseSchema
    {
        [JsonPropertyName("table_name")]
        public string TableName { get; set; }

        [JsonPropertyName("column_name")]
        public string ColumnName { get; set; }

        [JsonPropertyName("data_type")]
        public string DataType { get; set; }
    }
}
