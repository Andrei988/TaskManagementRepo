using System;
using Newtonsoft.Json;

namespace BlazorTest.Model
{
    public class Task
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("iscomplete", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsComplete { get; set; }

        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        [JsonProperty("projectid", NullValueHandling = NullValueHandling.Ignore)]
        public int ProjectId { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("starttime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime StartTime { get; set; }

        [JsonProperty("endtime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime EndTime { get; set; }

        [JsonProperty("colorlabel", NullValueHandling = NullValueHandling.Ignore)]
        public string ColorLabel { get; set; }
    }
}