using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Tier3Slit.Models.Entities
{
    public class ProjectChannel
    {
        [Display(Name = "ProjectId")]
        [JsonProperty("projectid", NullValueHandling = NullValueHandling.Ignore)]
        public int ProjectId { get; set; }

        [Display(Name = "ChannelId")]
        [JsonProperty("channelid", NullValueHandling = NullValueHandling.Ignore)]
        public int ChannelId { get; set; }
    }
}