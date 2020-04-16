using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tier3Slit.Models.Entities
{
    public interface IUser
    {
        [Key]
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Username string length error.")]
        [DataType(DataType.Text)]
        string Username { get; set; }

        [Display(Name = "First name")]
        [Required(ErrorMessage = "First name is required.")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "First name string length error.")]
        [DataType(DataType.Text)]
        string FirstName { get; set; }

        [Display(Name = "Last name")]
        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Last name string length error.")]
        [DataType(DataType.Text)]
        string LastName { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Gender is required.")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Gender string length error.")]
        [DataType(DataType.Text)]
        string Gender { get; set; }

        [Display(Name = "Hash")]
        [DataType(DataType.Text)]
        string Hash { get; set; }

        [Display(Name = "Salt")]
        [DataType(DataType.Text)]
        string Salt { get; set; }

        IEnumerable<ChannelUser> Channels { get; set; }
        IEnumerable<ProjectUser> Projects { get; set; }
    }
}