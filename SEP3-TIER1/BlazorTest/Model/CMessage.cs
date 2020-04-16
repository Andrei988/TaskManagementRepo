using System;
using Newtonsoft.Json;

namespace BlazorTest.Model
{
    public class CMessage
    {
        [JsonProperty("channelid", NullValueHandling = NullValueHandling.Ignore)]
        public int ChannelId { get; set; }

        [JsonProperty("sender", NullValueHandling = NullValueHandling.Ignore)]
        public string Sender { get; set; }

        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        [JsonProperty("timesent", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime TimeSent { get; set; }
    }
}