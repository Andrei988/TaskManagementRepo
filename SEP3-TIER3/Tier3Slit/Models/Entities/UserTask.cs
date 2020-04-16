using Newtonsoft.Json;

namespace Tier3Slit.Models.Entities
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class UserTask
    {
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        [JsonProperty("taskid", NullValueHandling = NullValueHandling.Ignore)]
        public int TaskId { get; set; }
    }
}