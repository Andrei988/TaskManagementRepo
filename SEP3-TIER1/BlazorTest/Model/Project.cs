using Newtonsoft.Json;
using System.Collections.Generic;

namespace BlazorTest.Model
{
    public class Project
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("channels", NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Channel> Channels { get; set; }

        [JsonProperty("ownerusername", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerUsername { get; set; }

        [JsonProperty("users", NullValueHandling = NullValueHandling.Ignore)]
        public virtual IEnumerable<ProjectUser> Users { get; set; }

    }
}