using Newtonsoft.Json;
using System.Collections.Generic;

namespace BlazorTest.Model
{
    public class Fields
    {
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public User User { get; set; }

        [JsonProperty("projects", NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Project> Projects { get; set; }

        [JsonProperty("pendinginvitation", NullValueHandling = NullValueHandling.Ignore)]
        public PendingInvitation PendingInvitation { get; set; }

        [JsonProperty("channels", NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Channel> Channels { get; set; }

        [JsonProperty("channelusers", NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ChannelUser> ChannelUsers { get; set; }

        [JsonProperty("projectchannels", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProjectChannel> ProjectChannels { get; set; }

        [JsonProperty("channelmessages", NullValueHandling = NullValueHandling.Ignore)]

        public List<CMessage> ChannelMessages { get; set; }

        [JsonProperty("comments", NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TaskComment> Comments { get; set; }

        [JsonProperty("tasks", NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Task> Tasks { get; set; }

        [JsonProperty("subtasks", NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SubTask> SubTasks { get; set; }

        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        [JsonProperty("secondpassword", NullValueHandling = NullValueHandling.Ignore)]
        public string SecondPassword { get; set; }

        [JsonProperty("responsecode", NullValueHandling = NullValueHandling.Ignore)]
        public int ResponseCode { get; set; }

        [JsonProperty("responsedescription", NullValueHandling = NullValueHandling.Ignore)]
        public string ResponseDescription { get; set; }
    }
}