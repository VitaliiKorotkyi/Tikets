using System.ComponentModel.DataAnnotations;
using VKTiketsPG.Data.Base;

namespace VKTiketsPG.Models
{
    public class Producer : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile picture is required  ")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full name is required  ")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Bio is required  ")]
        public string Bio { get; set; }
        public List<Movie> Movies { get; set; }

    }
}
