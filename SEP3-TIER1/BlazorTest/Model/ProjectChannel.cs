using Newtonsoft.Json;

namespace BlazorTest.Model
{
    public class ProjectChannel
    {
        [JsonProperty("projectid", NullValueHandling = NullValueHandling.Ignore)]
        public int ProjectId { get; set; }

        [JsonProperty("channelid", NullValueHandling = NullValueHandling.Ignore)]
        public int ChannelId { get; set; }
    }
}