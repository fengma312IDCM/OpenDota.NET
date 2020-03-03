namespace OpenDotaDotNet.Models.Distributions
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class Mmr
    {
        [JsonPropertyName("command")]
        public string Command { get; set; }

        [JsonPropertyName("rowCount")]
        public long RowCount { get; set; }

        //// [JsonPropertyName("oid")]
        //// public object Oid { get; set; }

        [JsonPropertyName("rows")]
        public List<MmrRow> Rows { get; set; }

        [JsonPropertyName("fields")]
        public List<Field> Fields { get; set; }

        //// [JsonPropertyName("_parsers")]
        //// public List<object> Parsers { get; set; }

        //// [JsonPropertyName("RowCtor")]
        //// public object RowCtor { get; set; }

        [JsonPropertyName("rowAsArray")]
        public bool RowAsArray { get; set; }

        [JsonPropertyName("sum")]
        public Sum Sum { get; set; }
    }
}
