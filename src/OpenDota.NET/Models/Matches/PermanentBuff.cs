namespace OpenDotaDotNet.Models.Matches
{
    using System.Text.Json.Serialization;

    public class PermanentBuff
    {
        // List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/permanent_buffs.json
        [JsonPropertyName("permanent_buff")]
        public long PermanentBuffPermanentBuff { get; set; }

        [JsonPropertyName("stack_count")]
        public long StackCount { get; set; }
    }
}
