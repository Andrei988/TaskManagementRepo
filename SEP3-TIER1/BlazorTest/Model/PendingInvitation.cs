using Newtonsoft.Json;

namespace BlazorTest.Model
{
    public class PendingInvitation
    {
        [JsonProperty("projectid", NullValueHandling = NullValueHandling.Ignore)]
        public int ProjectId { get; set; }

        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }
    }
}
