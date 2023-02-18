using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Tickits.Data.Base;

namespace Tickits.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Must be between 3 and 450 chars")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }
       
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
