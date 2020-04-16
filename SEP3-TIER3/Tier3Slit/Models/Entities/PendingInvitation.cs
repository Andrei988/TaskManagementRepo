using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Tier3Slit.Models.Entities
{
    public class PendingInvitation
    {
        [Display(Name = "ProjectId")]
        [JsonProperty("projectid", NullValueHandling = NullValueHandling.Ignore)]
        public int ProjectId { get; set; }

        [Display(Name = "Username")]
        [DataType(DataType.Text)]
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }
    }
}