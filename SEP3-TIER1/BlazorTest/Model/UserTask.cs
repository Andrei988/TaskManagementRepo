using Newtonsoft.Json;

namespace BlazorTest.Model
{
    public class UserTask
    {
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        [JsonProperty("taskid", NullValueHandling = NullValueHandling.Ignore)]
        public int TaskId { get; set; }
    }
}