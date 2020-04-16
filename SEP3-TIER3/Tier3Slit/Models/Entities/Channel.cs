using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Tier3Slit.Models.Entities
{
    public class Channel
    {
        [Key]
        [Display(Name = "Id")]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }

        [Display(Name = "Title")]
        [DataType(DataType.Text)]
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [Display(Name = "Users")]
        [JsonProperty("users", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ChannelUser> Users { get; set; }

        [Display(Name = "Project")]
        [JsonProperty("project", NullValueHandling = NullValueHandling.Ignore)]
        public Project Project { get; set; }

        [Display(Name = "ProjectId")]
        [JsonProperty("projectid", NullValueHandling = NullValueHandling.Ignore)]
        public int ProjectId { get; set; }
    }
}