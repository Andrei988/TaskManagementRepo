using System;
using Newtonsoft.Json;

namespace BlazorTest.Model
{
    public class SubTask
    {
        [JsonProperty("taskid", NullValueHandling = NullValueHandling.Ignore)]
        public int TaskId { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("iscomplete", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsComplete { get; set; }

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