using System.ComponentModel.DataAnnotations;
namespace DojoSurvey.Models
{
    public class Survey
    {
        [Display(Name = "Your Name: ")]
        [Required(ErrorMessage ="Please provide your name.")]
        [MinLength(2, ErrorMessage = "Name must be atleast 2 characters.")]
        public string Name {get; set;}

        [Required]
        [Display(Name = "Dojo Location: ")]
        public string Location {get; set;}

        [Required]
        [Display(Name = "Favorite Language: ")]
        public string FaveLang {get; set;}

        [Display(Name = "Comment (optional): ")]
        [MinLength(20, ErrorMessage ="Your comment must be atleast 20 characters.")]
        public string Comment {get; set;}
    }
}