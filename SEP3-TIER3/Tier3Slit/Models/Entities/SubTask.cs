using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Tier3Slit.Models.Entities
{
    public class SubTask
    {
        [Display(Name = "Task id")]
        [JsonProperty("taskid", NullValueHandling = NullValueHandling.Ignore)]
        public int TaskId { get; set; }

        [Key]
        [Display(Name = "SubTask id")]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }

        [Display(Name = "IsComplete")]
        [JsonProperty("iscomplete", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsComplete { get; set; }

        [Display(Name = "Description")]
        [DataType(DataType.Text)]
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [Display(Name = "Start Time")]
        [JsonProperty("starttime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime StartTime { get; set; }

        [Display(Name = "End Time")]
        [JsonProperty("endtime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime EndTime { get; set; }

        [Display(Name = "Color label")]
        [DataType(DataType.Text)]
        [JsonProperty("colorlabel", NullValueHandling = NullValueHandling.Ignore)]
        public string ColorLabel { get; set; }
    }
}