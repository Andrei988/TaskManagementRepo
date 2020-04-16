using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace BlazorTest.Model
{
    public class TaskComment
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("taskid", NullValueHandling = NullValueHandling.Ignore)]
        public int TaskId { get; set; }

        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime Date { get; set; }
    }
}