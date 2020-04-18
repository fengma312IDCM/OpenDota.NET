namespace OpenDotaDotNet.Models.Distributions
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class CountryMmr
    {
        [JsonPropertyName("command")]
        public string Command { get; set; }

        [JsonPropertyName("rowCount")]
        public long RowCount { get; set; }

        //// [JsonPropertyName("oid")]
        //// public object Oid { get; set; }

        [JsonPropertyName("rows")]
        public IEnumerable<CountryMmrRow> Rows { get; set; }

        [JsonPropertyName("fields")]
        public IEnumerable<Field> Fields { get; set; }

        //// [JsonPropertyName("_parsers")]
        //// public IEnumerable<object> Parsers { get; set; }

        //// [JsonPropertyName("_types")]
        //// public object Types { get; set; }

        //// [JsonPropertyName("RowCtor")]
        //// public object RowCtor { get; set; }

        [JsonPropertyName("rowAsArray")]
        public bool RowAsArray { get; set; }
    }
}
