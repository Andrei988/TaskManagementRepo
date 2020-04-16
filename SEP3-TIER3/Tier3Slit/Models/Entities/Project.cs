using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Tier3Slit.Models.Entities
{
    public class Project
    {
        [Key]
        [Display(Name = "Id")]
        [DataType(DataType.Text)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }

        [Display(Name = "Title")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Title string length error.")]
        [DataType(DataType.Text)]
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [Display(Name = "Description")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Description string length error.")]
        [DataType(DataType.Text)]
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [Display(Name = "Channels")]
        [JsonProperty("channels", NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Channel> Channels { get; set; }

        [Display(Name = "Users")]
        [JsonProperty("users", NullValueHandling = NullValueHandling.Ignore)]
        public virtual IEnumerable<ProjectUser> Users { get; set; }

        [Display(Name = "Owner username")]
        [JsonProperty("ownerusername", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerUsername { get; set; }

        public Project()
        {
            Channels = new List<Channel>();
        }
    }
}