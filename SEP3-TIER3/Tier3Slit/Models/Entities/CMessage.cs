using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Tier3Slit.Models.Entities
{
    public class CMessage : IComparable<CMessage>
    {
        [Key] [Display(Name = "Id")] public int Id { get; set; }

        [Display(Name = "ChannelId")]
        [JsonProperty("channelid", NullValueHandling = NullValueHandling.Ignore)]
        public int ChannelId { get; set; }

        [Display(Name = "Sender Username")]
        [DataType(DataType.Text)]
        [JsonProperty("sender", NullValueHandling = NullValueHandling.Ignore)]
        public string Sender { get; set; }

        [Display(Name = "Content")]
        [DataType(DataType.Text)]
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        [Display(Name = "Time sent")]
        [JsonProperty("timesent", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime TimeSent { get; set; }

        public int CompareTo(CMessage other)
        {
            return TimeSent.CompareTo(other.TimeSent);
        }
    }
}