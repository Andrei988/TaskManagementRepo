using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Newtonsoft.Json;

namespace Tier3Slit.Models.Entities
{
    public class ChannelUser
    {
        [Display(Name = "ChannelId")]
        [JsonProperty("channelid", NullValueHandling = NullValueHandling.Ignore)]
        public int ChannelId { get; set; }

        [JsonProperty("channel", NullValueHandling = NullValueHandling.Ignore)]
        public Channel Channel { get; set; }

        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public User User { get; set; }

        [Display(Name = "Username")]
        [DataType(DataType.Text)]
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }
    }
}