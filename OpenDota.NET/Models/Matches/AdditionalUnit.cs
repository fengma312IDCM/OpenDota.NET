namespace OpenDotaDotNet.Models.Matches
{
    using System.Text.Json.Serialization;

    public class AdditionalUnit
    {
        // Name of unit
        [JsonPropertyName("unitname")]
        public string Unitname { get; set; }

        // Id of item 0
        [JsonPropertyName("item_0")]
        public int Item0 { get; set; }

        // Id of item 1
        [JsonPropertyName("item_1")]
        public int Item1 { get; set; }

        // Id of item 2
        [JsonPropertyName("item_2")]
        public int Item2 { get; set; }

        // Id of item 3
        [JsonPropertyName("item_3")]
        public int Item3 { get; set; }

        // Id of item 4
        [JsonPropertyName("item_4")]
        public int Item4 { get; set; }

        // Id of item 5
        [JsonPropertyName("item_5")]
        public int Item5 { get; set; }

        // Id of backpack item 0
        [JsonPropertyName("backpack_0")]
        public int Backpack0 { get; set; }

        // Id of backpack item 1
        [JsonPropertyName("backpack_1")]
        public int Backpack1 { get; set; }

        // Id of backpack item 2
        [JsonPropertyName("backpack_2")]
        public int Backpack2 { get; set; }
    }
}
