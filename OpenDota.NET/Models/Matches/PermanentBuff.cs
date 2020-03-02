namespace OpenDotaDotNet.Models.Matches
{
    using Newtonsoft.Json;

    public class PermanentBuff
    {
        // List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/permanent_buffs.json
        [JsonProperty("permanent_buff")]
        public long PermanentBuffPermanentBuff { get; set; }

        [JsonProperty("stack_count")]
        public long StackCount { get; set; }
    }
}
