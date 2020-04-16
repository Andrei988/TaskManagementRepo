using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tier3Slit.Models.Entities
{
    public class User : IUser
    {
        [Key] public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Hash { get; set; }
        public string Salt { get; set; }
        public virtual IEnumerable<ChannelUser> Channels { get; set; }
        public virtual IEnumerable<ProjectUser> Projects { get; set; }
        public virtual IEnumerable<UserTask> Tasks { get; set; }
    }
}