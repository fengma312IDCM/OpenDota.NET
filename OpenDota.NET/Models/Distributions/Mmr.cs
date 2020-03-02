namespace OpenDotaDotNet.Models.Distributions
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class Mmr
    {
        [JsonProperty("command")]
        public string Command { get; set; }

        [JsonProperty("rowCount")]
        public long RowCount { get; set; }

        //// [JsonProperty("oid")]
        //// public object Oid { get; set; }

        [JsonProperty("rows")]
        public List<MmrRow> Rows { get; set; }

        [JsonProperty("fields")]
        public List<Field> Fields { get; set; }

        //// [JsonProperty("_parsers")]
        //// public List<object> Parsers { get; set; }

        //// [JsonProperty("RowCtor")]
        //// public object RowCtor { get; set; }

        [JsonProperty("rowAsArray")]
        public bool RowAsArray { get; set; }

        [JsonProperty("sum")]
        public Sum Sum { get; set; }
    }
}
