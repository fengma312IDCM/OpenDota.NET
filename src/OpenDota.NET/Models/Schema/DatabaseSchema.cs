namespace OpenDotaDotNet.Models.Schema
{
    using System.Text.Json.Serialization;

    public class DatabaseSchema
    {
        /// <summary>
        /// Gets or sets the table name.
        /// </summary>
        [JsonPropertyName("table_name")]
        public string TableName { get; set; }

        /// <summary>
        /// Gets or sets the column name.
        /// </summary>
        [JsonPropertyName("column_name")]
        public string ColumnName { get; set; }

        /// <summary>
        /// Gets or sets the data type.
        /// </summary>
        [JsonPropertyName("data_type")]
        public string DataType { get; set; }
    }
}
