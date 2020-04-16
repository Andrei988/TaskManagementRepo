using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Tier3Slit.Models.Entities
{
    public class TaskComment
    {
        [Display(Name = "CommentId")]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }

        [Display(Name = "TaskId")]
        [JsonProperty("taskid", NullValueHandling = NullValueHandling.Ignore)]
        public int TaskId { get; set; }

        [Display(Name = "Username")]
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        [Display(Name = "Comment")]
        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

        [Display(Name = "Date")]
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime Date { get; set; }
    }
}